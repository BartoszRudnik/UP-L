using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaMuzyczna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WczytajButtonClick(object sender, EventArgs e)
        {

            String loadFilePath;
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
        
    }
    
}