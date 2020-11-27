using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace KartaMuzyczna
{
    public partial class Form1 : Form
    {
        
        private String loadFilePath;
        private SoundPlayer soundPlayer;
        private WindowsMediaPlayer windowsPlayer;
        
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
                textBox1.Text += dataString.Substring(0, 4);
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
        
    }
    
}