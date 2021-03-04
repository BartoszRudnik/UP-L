using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Barcode;

namespace DrukowanieKodowPaskowych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox2.Items.Add("Maly");
            comboBox2.Items.Add("Sredni");
            comboBox2.Items.Add("Duzy");

            comboBox2.SelectedIndex = 0;
            
            foreach (object printer in PrinterSettings.InstalledPrinters)
            {

                comboBox1.Items.Add(printer.ToString());

            }

            if (comboBox1.Items.Count > 0)
            {

                comboBox1.SelectedIndex = 0;

            }
            
        }

        private bool codeLength(string kodPaskowy)
        {
            if (kodPaskowy.Length != 12)
                return false;
            else
            {
                return true;
            }
        }
        
        private static Image usunNapis(Image barCodeImage)
        {
            
            Rectangle newArea = new Rectangle();

            newArea.X = 0;
            newArea.Y = 13;
            newArea.Width = barCodeImage.Width;
            newArea.Height = barCodeImage.Height - 13;
            
            Bitmap bmpImage = new Bitmap(barCodeImage);
            return bmpImage.Clone(newArea, bmpImage.PixelFormat);
            
        }

        private void generateBarCode_ButtonClick(object sender, EventArgs e)
        {
            string barCode = textBox1.Text.Trim();
            
            try
            {
                
                if(!codeLength(barCode))
                    throw new Exception();
                
                BarcodeSettings barcodeSettings = new BarcodeSettings();

                barcodeSettings.Type = BarCodeType.EAN13;
                barcodeSettings.Data = barCode;
                barcodeSettings.UseChecksum = CheckSumMode.ForceEnable;
                barcodeSettings.ShowTextOnBottom = true;
                barcodeSettings.TextAlignment = StringAlignment.Center;
                
                BarCodeGenerator generator = new BarCodeGenerator(barcodeSettings);

                Image barCodeImage = generator.GenerateImage();
                barCodeImage = usunNapis(barCodeImage);

                pictureBox1.Image = barCodeImage;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Podano kod o zlej dlugosci");
            }

        }

        private void saveBarCode_ButtonClick(object sender, EventArgs e)
        {

            try
            {

                if (pictureBox1.Image == null)
                    throw new Exception();

                string savePath = "";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "jpg";
                saveFile.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    savePath = saveFile.FileName;
                }

                MessageBox.Show(savePath);

                pictureBox1.Image.Save(savePath, ImageFormat.Jpeg);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wygenerowano kodu paskowego");
            }

        }

        private void printBarCode_ButtonClick(object sender, EventArgs e)
        {
            
            string printer = comboBox1.SelectedItem.ToString();
            myPrinters.SetDefaultPrinter(printer);
            
            PrintDocument printBarCode = new PrintDocument();

            printBarCode.PrintPage += PrintPage;
            printBarCode.Print();

        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {

            try
            {

                int imageHeight = 0;
                int imageWidth = 0;

                if (comboBox2.SelectedItem.Equals("Maly"))
                {
                    imageHeight = 100;
                    imageWidth = 300;
                }
                else if (comboBox2.SelectedItem.Equals("Sredni"))
                {
                    imageHeight = 200;
                    imageWidth = 400;
                }
                else if (comboBox2.SelectedItem.Equals("Duzy"))
                {
                    imageHeight = 300;
                    imageWidth = 500;
                }

                Image barCodeImage = pictureBox1.Image;

                Rectangle imageLocation = e.MarginBounds;

                imageLocation.Height = imageHeight;
                imageLocation.Width = imageWidth;

                e.Graphics.DrawImage(barCodeImage, imageLocation);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        
    }
    
    public class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

    }
    
}