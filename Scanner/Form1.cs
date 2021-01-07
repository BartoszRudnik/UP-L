using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIA;
using CommonDialog = WIA.CommonDialog;

namespace Scanner
{
    public partial class Form1 : Form
    {

        private DeviceInfo scanner;
        private CommonDialog commonDialog;
        private String filePath;
        private String formatID;
        private int resolution;
        private int scanWidth;
        private int scanHeight;
        private int scanColorMode;
        private int scanBrightness;
        private int scanContrast;
        private int countScannings;
        private String success = "Skanowanie zostało zakonczone";
        
        public Form1()
        {
            InitializeComponent();

            radioButtonJPEG.Checked = true;
            
            resolution = 300;
            scanWidth = (int) (resolution * 8.26);
            scanHeight = (int) (resolution * 11.69);
            scanColorMode = 1;
            scanContrast = 0;
            scanBrightness = 0;
            formatID = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
            
            textBoxRozdzielczosc.Text = resolution.ToString();
            textBoxSzerokosc.Text = scanWidth.ToString();
            textBoxWysokosc.Text = scanHeight.ToString();

            comboBox2.Items.Add("Kolorowe");
            comboBox2.Items.Add("Szare");
            comboBox2.Items.Add("Czarno biale");
            comboBox2.SelectedIndex = 0;

        }

        private void chooseScanner()
        {
            
            DeviceManager deviceManager = new DeviceManager();
            DeviceInfos devices = deviceManager.DeviceInfos;

            for (int i = 1; i <= devices.Count; i++)
            {

                DeviceInfo device = devices[i];

                if (device.Type == WiaDeviceType.ScannerDeviceType && device.Properties["Name"].get_Value() == comboBox1.SelectedItem.ToString())
                {
                    scanner = device;
                    break;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeviceManager deviceManager = new DeviceManager();
            DeviceInfos devices = deviceManager.DeviceInfos;

            for (int i = 1; i <= devices.Count; i++)
            {

                DeviceInfo device = devices[i];

                if (device.Type == WiaDeviceType.ScannerDeviceType)
                {
                    comboBox1.Items.Add(device.Properties["Name"].get_Value());
                }

            }

            if(comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

        }
        
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }
        
        private void SetDeviceIntProperty(ref Device device, int propertyID, int propertyValue)
        {
            foreach (Property p in device.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    object value = propertyValue;
                    p.set_Value(ref value);
                    break;
                }
            }
        }
        
        private void SetItemIntProperty(ref Item item, int propertyID, int propertyValue)
        {
            foreach (Property p in item.Properties)
            {
                if (p.PropertyID == propertyID)
                {
                    object value = propertyValue;
                    p.set_Value(ref value);
                    break;
                }
            }
        }
        
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                
                commonDialog = new CommonDialog();
                countScannings++;

                chooseScanner();
                
                Device connectedDevice = scanner.Connect();
                Item scannerItem = connectedDevice.Items[1];

                AdjustScannerSettings(scannerItem, resolution, 0, 0, scanWidth, scanHeight, scanBrightness, scanContrast, scanColorMode);
                SetDeviceIntProperty(ref connectedDevice, 3088, 1);
                SetDeviceIntProperty(ref connectedDevice, 3096, 1);
                
                ImageFile image = commonDialog.ShowTransfer(scannerItem, formatID, true);

                filePath += @"\";
                filePath += countScannings.ToString();
                filePath += "scan";

                if (radioButtonBMP.Checked)
                    filePath += ".bmp";
                if (radioButtonPNG.Checked)
                    filePath += ".png";
                if (radioButtonJPEG.Checked)
                    filePath += ".jpeg";
                if (radioButtonTIFF.Checked)
                    filePath += ".tiff";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                image.SaveFile(filePath);

                MessageBox.Show(success);

                Image image2 = Image.FromFile(filePath);
                pictureBox1.Image = image2;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    filePath = folderBrowserDialog.SelectedPath;
                }
            }
        }


        private void radioButtonPNG_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPNG.Checked)
                formatID = "{B96B3CAF-0728-11D3-9D7B-0000F81EF32E}";
        }


        private void radioButtonJPEG_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonJPEG.Checked)
                formatID = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
        }

        private void radioButtonTIFF_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTIFF.Checked)
                formatID = "{B96B3CB1-0728-11D3-9D7B-0000F81EF32E}";
        }

        private void radioButtonBMP_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonBMP.Checked)
                formatID = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
        }

        private void textBoxRozdzielczosc_TextChanged(object sender, EventArgs e)
        {
            
            resolution = Int32.Parse(textBoxRozdzielczosc.Text);
            
            scanWidth = (int) (resolution * 8.26);
            scanHeight = (int) (resolution * 11.69);
            
            textBoxSzerokosc.Text = scanWidth.ToString();
            textBoxWysokosc.Text = scanHeight.ToString();
            
        }

        private void textBoxSzerokosc_TextChanged(object sender, EventArgs e)
        {
            scanWidth = Int32.Parse(textBoxSzerokosc.Text);
        }

        private void textBoxWysokosc_TextChanged(object sender, EventArgs e)
        {
            scanHeight = Int32.Parse(textBoxWysokosc.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.Text == "Kolorowe")
                scanColorMode = 1;
            else if (comboBox2.Text == "Czarno biale")
                scanColorMode = 2;
            else if (comboBox2.Text == "Szare")
                scanColorMode = 4;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scanBrightness = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            scanContrast = trackBar2.Value;
        }
    }
    
}