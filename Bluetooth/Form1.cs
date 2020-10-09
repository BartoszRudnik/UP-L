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
             
            BluetoothClient client = new BluetoothClient();
           
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();

            foreach (BluetoothDeviceInfo device in devices)
            {
                listBox1.Items.Add(device);
                listBox2.Items.Add(device.DeviceName);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BluetoothDeviceInfo device = (BluetoothDeviceInfo) listBox1.SelectedItem;
            
            textBox1.Text = device.DeviceName.ToString();
            textBox2.Text = device.Connected.ToString();
            textBox3.Text = device.Authenticated.ToString();
            textBox4.Text = device.Remembered.ToString();

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
    }
}