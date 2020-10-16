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
        private int nasycenie;
        private int jasnosc;
        private int kontrast;
        private BrightnessCorrection brightness;
        private SaturationCorrection saturation;
        private ContrastCorrection contrast;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            filterDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in filterDevices)
            {
                comboBox1.Items.Add(device.Name);
            }

            if(comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

        }
        
        private void button3_Click(object sender, EventArgs e)
        { 
            newVideo = new VideoCaptureDevice(filterDevices[comboBox1.SelectedIndex].MonikerString);
            newVideo.NewFrame += VideoCaptureDevice_NewFrame;
            newVideo.Start();
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
            
            pictureBox1.Image = image;
            
            if (recording == true)
            {
                writer.WriteVideoFrame(image);
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
    }
    
}