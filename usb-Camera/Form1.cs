using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Video.FFMPEG;
using AForge.Vision.Motion;

namespace usb_Camera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterDevices;
        private VideoCaptureDevice newVideo;
        private FolderBrowserDialog folderBrowser;
        private string savePath;
        private SaveFileDialog saveFile;
        private VideoFileWriter writer;
        private bool recording = false;
        private bool detecting = false;
        private int nasycenie;
        private int jasnosc;
        private int kontrast;
        private BrightnessCorrection brightness;
        private SaturationCorrection saturation;
        private ContrastCorrection contrast;
        private int index;
        private MotionDetector motionDetector;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            filterDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in filterDevices)
            {
                comboBox1.Items.Add(device.Name);
            }

            if(comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            textBox4.Text = "Detekcja wylaczona";

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
                   
            newVideo = new VideoCaptureDevice(filterDevices[comboBox1.SelectedIndex].MonikerString);
            newVideo.NewFrame += VideoCaptureDevice_NewFrame;
            newVideo.Start();
            
            motionDetector = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
            
            for (int i = 0; i < newVideo.VideoCapabilities.Length; i++)
            {
                string resolution = Convert.ToString(i);
                string resolution_size = newVideo.VideoCapabilities[i].FrameSize.ToString();
                Rozdzielczosc.Items.Add(resolution + ". " + resolution_size);
            }
            
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {

            Bitmap image = (Bitmap) e.Frame.Clone();
            
            brightness = new BrightnessCorrection(jasnosc);
            image = brightness.Apply((Bitmap) image.Clone());

            saturation = new SaturationCorrection(nasycenie);
            image = saturation.Apply((Bitmap) image.Clone());
            
            contrast = new ContrastCorrection(kontrast);
            image = contrast.Apply((Bitmap) image.Clone());

            if (recording == true)
            {
                writer.WriteVideoFrame(image);
            }
    
            if(detecting)
            {
               if (motionDetector.ProcessFrame(image) > 0.05)
                    {
                        textBox4.Text = "Wykryto ruch";
                        pictureBox1.Image = image;
                    }
                    else
                    {
                        textBox4.Text = "Brak ruchu";
                        pictureBox1.Image = image;
                    }
            }
            else
            {
                pictureBox1.Image = image;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newVideo.IsRunning)
            {
                newVideo.SignalToStop();
                newVideo.WaitForStop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (newVideo.IsRunning)
            {
                newVideo.SignalToStop();
                newVideo.WaitForStop();
                pictureBox1.Image = null;
                Rozdzielczosc.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            textBox1.Text = folderBrowser.SelectedPath;
            savePath = folderBrowser.SelectedPath;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newVideo.SignalToStop();
            newVideo.WaitForStop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (savePath != null)
            {
                pictureBox1.Image.Save(savePath + "\\[UP].jpg");
                MessageBox.Show("Poprawnie zapisano zdjecie");
            }
            else
            {
                MessageBox.Show("Nie podano sciezki do zapisu pliku");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            writer = new VideoFileWriter();

            saveFile.FileName = "recordedVideo";
            saveFile.DefaultExt = ".avi";
            saveFile.AddExtension = true;

            saveFile.ShowDialog();

            writer.Open(saveFile.FileName, pictureBox1.Image.Width, pictureBox1.Image.Height);
            recording = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
                recording = false;
                writer.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nasycenie = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            jasnosc = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            kontrast = trackBar3.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            nasycenie = trackBar1.Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            trackBar2.Value = 0;
            jasnosc = trackBar2.Value;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            trackBar3.Value = 0;
            kontrast = trackBar3.Value;
        }

        private void Rozdzielczosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Rozdzielczosc.SelectedIndex;
            textBox2.Text = index.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newVideo.SignalToStop();
            newVideo.WaitForStop();
            pictureBox1.Image = null; 
            newVideo = new VideoCaptureDevice(filterDevices[comboBox1.SelectedIndex].MonikerString);
            newVideo.NewFrame += VideoCaptureDevice_NewFrame;
            newVideo.VideoResolution = newVideo.VideoCapabilities[index];
            motionDetector = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
            newVideo.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            detecting = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            detecting = false;
            textBox4.Text = "Detekcja wylaczona";
        }
    }
    
}