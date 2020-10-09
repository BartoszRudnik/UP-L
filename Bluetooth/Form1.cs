using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            BluetoothClient client = new BluetoothClient();
           
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();

            foreach (BluetoothDeviceInfo device in devices)
            {
                listBox1.Items.Add(device);
                listBox2.Items.Add(device.DeviceName);
            }
            
            MessageBox.Show("Zakonczono wyszukiwanie");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BluetoothDeviceInfo device = (BluetoothDeviceInfo) listBox1.SelectedItem;
            
            textBox1.Text = device.DeviceName.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pin = "1234";
            
            BluetoothDeviceInfo device = (BluetoothDeviceInfo) listBox1.SelectedItem;
            bool nowPaired = BluetoothSecurity.PairRequest(device.DeviceAddress, pin);

            if (nowPaired)
            {
                MessageBox.Show("Poprawne parowanie");
            }
            else
            {
                MessageBox.Show("Niepoprawne parowanie");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = textBox2.Text;
            string fileName;

            BluetoothDeviceInfo device = (BluetoothDeviceInfo) listBox1.SelectedItem;
            
            Uri uri = new Uri("obex://" + device.DeviceAddress + "/" + filePath);
         
            ObexWebRequest newRequest = new ObexWebRequest(uri);
            newRequest.ReadFile(filePath);

            ObexWebResponse response = (ObexWebResponse)newRequest.GetResponse();

            response.Close();

            MessageBox.Show(response.StatusCode.ToString());

        }
    }
}