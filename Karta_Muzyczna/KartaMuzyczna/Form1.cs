using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using SharpDX;
using SharpDX.Multimedia;
using SharpDX.XAudio2;
using WMPLib;
using WaveFormat = SharpDX.Multimedia.WaveFormat;

namespace KartaMuzyczna
{
    public partial class Form1 : Form
    {
        
        private String loadFilePath;
        private SoundPlayer soundPlayer;
        private WindowsMediaPlayer windowsPlayer;
        private WaveOut waveOut;
        private XAudio2 xAudio2;
        private SoundStream soundStream;
        private SourceVoice sourceVoice;
        private MasteringVoice masteringVoice;
        private List<WaveInCapabilities> listOfMicrophones;
        private String saveFile;
        private WaveIn waveIn;
        private WaveFileWriter fileWriter;
        private int directSoundEffect = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void WczytajButtonClick(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            
            OpenFileDialog loadFile = new OpenFileDialog();

            if (loadFile.ShowDialog() == DialogResult.OK)
            {

                loadFilePath = loadFile.FileName;
                
                FileStream fileStream = new FileStream(loadFilePath,FileMode.Open);
                BinaryReader reader = new BinaryReader(fileStream);

                byte[] riff = reader.ReadBytes(4);
                String riffString = Encoding.Default.GetString(riff);

                textBox1.Text += "RIFF: ";
                textBox1.Text += riffString.Substring(0, 4);
                textBox1.Text += "\r\n fileSize[B]: ";
                textBox1.Text += reader.ReadInt32();

                byte[] wave = reader.ReadBytes(8);
                String waveString = Encoding.Default.GetString(wave);

                textBox1.Text += "\r\n fileFormat: ";
                textBox1.Text += waveString.Substring(0, 4);
                textBox1.Text += "\r\n formatChunkMarker: ";
                textBox1.Text += waveString.Substring(4, 4);
                textBox1.Text += "\r\n formatChunkMarkerSize: ";
                textBox1.Text += reader.ReadInt32();
                textBox1.Text += "\r\n formatType: ";
                textBox1.Text += reader.ReadInt16();
                textBox1.Text += "\r\n numberOfChannels: ";
                textBox1.Text += reader.ReadInt16();
                textBox1.Text += "\r\n sampleRate: ";
                textBox1.Text += reader.ReadInt32();
                textBox1.Text += "\r\n BytesPerSecond: ";
                textBox1.Text += reader.ReadInt32();
                textBox1.Text += "\r\n BytesPerSample: ";
                textBox1.Text += reader.ReadInt16();
                textBox1.Text += "\r\n BitesPerSample: ";
                textBox1.Text += reader.ReadInt16();

                byte[] data = reader.ReadBytes(4);
                String dataString = Encoding.Default.GetString(data);

                textBox1.Text += "\r\n dataStart: ";
                textBox1.Text += dataString;
                textBox1.Text += "\r\n dataSize: ";
                textBox1.Text += reader.ReadInt32();
                
                reader.Close();
                
            }

        }

        private void SystemMediaSoundPlayer_Start(object sender, EventArgs e)
        {
            
            try
            {
                soundPlayer = new SoundPlayer(loadFilePath);
                soundPlayer.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Wybrano bledny plik");
            }
            
        }

        private void SystemMediaSoundPlayer_Stop(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void WMP_MP3_Start(object sender, EventArgs e)
        {
            
            OpenFileDialog newFile = new OpenFileDialog();
            windowsPlayer = new WindowsMediaPlayer();
            
            if (newFile.ShowDialog() == DialogResult.OK)
            {
                    String mp3FilePath = newFile.FileName;

                    windowsPlayer.URL = mp3FilePath;
                    windowsPlayer.controls.play();

            }
            
        }

        private void WMP_MP3_Stop(object sender, EventArgs e)
        {
            windowsPlayer.controls.stop();
        }

        private void WMP_WAV_Start(object sender, EventArgs e)
        {

            try
            {
                
                if(loadFilePath == null)
                    throw new Exception();
                
                windowsPlayer = new WindowsMediaPlayer();
                windowsPlayer.URL = loadFilePath;
                windowsPlayer.controls.play();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Wybrano bledny plik");
            }

        }

        private void WMP_WAV_STOP(object sender, EventArgs e)
        {
            windowsPlayer.controls.stop();
        }

        private void nAudio_Start(object sender, EventArgs e)
        {

            try
            {

                if (loadFilePath == null)
                {
                    throw new Exception();
                }

                AudioFileReader reader = new AudioFileReader(loadFilePath);
                waveOut = new WaveOut();

                waveOut.Init(reader);
                waveOut.Play();

            }
            catch (Exception)
            {
                MessageBox.Show("Wybrano bledny plik");
            }
            
        }

        private void nAudio_Stop(object sender, EventArgs e)
        {
            waveOut.Stop();
        }
        
        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }


        private void PlaySound_Start(object sender, EventArgs e)
        {

            try
            {
                if (loadFilePath == null)
                {
                    throw new Exception();
                }


                PlaySound(loadFilePath, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);

            }
            catch (Exception)
            {
                MessageBox.Show("Wybrano bledny plik");
            }
            
        }

        private void PlaySound_Stop(object sender, EventArgs e)
        {
            PlaySound(null, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
        }

        private void DirectSound_Start(object sender, EventArgs e)
        {
            
            soundStream = new SoundStream(File.OpenRead(loadFilePath));
            WaveFormat format = soundStream.Format;

            AudioBuffer buffer = new AudioBuffer
            {
              Stream = soundStream.ToDataStream(),
              AudioBytes = (int)soundStream.Length,
              Flags = BufferFlags.EndOfStream
            };
            
            soundStream.Close();
            
            sourceVoice = new SourceVoice(xAudio2, format, true);
            sourceVoice.SubmitSourceBuffer(buffer, soundStream.DecodedPacketsInfo);
            sourceVoice.Start();

            if (directSoundEffect == 0)
            {
                SharpDX.XAPO.Fx.Echo effectEcho = new SharpDX.XAPO.Fx.Echo(xAudio2);   
                EffectDescriptor effectDescriptor = new EffectDescriptor(effectEcho);
                sourceVoice.SetEffectChain(effectDescriptor);
                sourceVoice.EnableEffect(0);

            }
            else if(directSoundEffect == 1)
            {
                SharpDX.XAPO.Fx.Reverb effectReverb = new SharpDX.XAPO.Fx.Reverb(xAudio2);   
                EffectDescriptor effectDescriptor = new EffectDescriptor(effectReverb);
                sourceVoice.SetEffectChain(effectDescriptor);
                sourceVoice.EnableEffect(0);
            }

        }

        private void DirectSound_Stop(object sender, EventArgs e)
        {
           
            sourceVoice.Stop();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xAudio2 = new XAudio2();
            xAudio2.StartEngine();
            masteringVoice = new MasteringVoice(xAudio2);
            textBox2.Text = "Nagrywanie wylaczone";
            
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDeviceCollection audioDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            comboBox2.Items.AddRange(audioDevices.ToArray());

            comboBox3.Items.Add("Bez");
            comboBox3.Items.Add("Echo");
            comboBox3.Items.Add("Reverb");
            comboBox3.SelectedIndex = 0;

        }

        private void checkEfekt()
        {
            if (comboBox3.SelectedItem.Equals("Bez"))
            {
                directSoundEffect = -1;
            }
            else if (comboBox3.SelectedItem.Equals("Echo"))
            {
                directSoundEffect = 0;
            }
            else
            {
                directSoundEffect = 1;
            }
                
        }

        private void searchMicrophones_Click(object sender, EventArgs e)
        {
            listOfMicrophones = new List<WaveInCapabilities>();
            comboBox1.Items.Clear();

            for (int i = 0; i < WaveIn.DeviceCount; i++)
                listOfMicrophones.Add(WaveIn.GetCapabilities(i));

            foreach (WaveInCapabilities micro in listOfMicrophones)
            {
                string item = micro.ProductName;
                comboBox1.Items.Add(item);
            }

            comboBox1.SelectedIndex = 0;

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFile = saveFileDialog.FileName;
            }
            
        }

        private void recordAudio_Click(object sender, EventArgs e)
        {

            try
            {
                if (saveFile == null)
                {
                    throw new Exception();
                }
                
                waveIn = new WaveIn();

                waveIn.DeviceNumber = comboBox1.SelectedIndex;
                waveIn.WaveFormat = new NAudio.Wave.WaveFormat();
            
                waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveInData);
                fileWriter = new WaveFileWriter(saveFile, waveIn.WaveFormat);
            
                waveIn.StartRecording();

                textBox2.Text = "Nagrywanie wlaczone";

            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pliku do zapisu");
            }
            
        }

        private void waveInData(object sender, WaveInEventArgs eventArgs)
        {
            
            fileWriter.Write(eventArgs.Buffer, 0, eventArgs.BytesRecorded);
            fileWriter.Flush();
            
        }

        private void stopRecording_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();

            textBox2.Text = "Nagrywanie wylaczone";

        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                MMDevice selectedDevice = (MMDevice) comboBox2.SelectedItem;
                progressBar1.Value = (int) selectedDevice.AudioMeterInformation.MasterPeakValue * 100;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEfekt();
        }
    }
    
}