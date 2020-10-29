using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using SlimDX.DirectInput;

namespace JoyStick
{
    public partial class Form1 : Form
    {
        private DirectInput directInput = new DirectInput();
        private SlimDX.DirectInput.Joystick newStick;
        private List <Joystick> sticks = new List<Joystick>();
        private bool[] joystickButtons;
        private bool leftClick = false;
        private bool rightClick = false;
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint flag, uint _x, uint _y, uint btn, uint exinfo);
        private const int MOUSEEVENT_LEFTDOWN = 0X02;
        private const int MOUSEEVENT_LEFTUP = 0X04;
        private const int MOUSEEVENT_RIGHTDOWN = 0X08;
        private const int MOUSEEVENT_RIGHTUP = 0X10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DeviceInstance newDevice in directInput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                
                newStick = new SlimDX.DirectInput.Joystick(directInput, newDevice.InstanceGuid);
                newStick.Acquire();
                
                foreach (DeviceObjectInstance DeviceObject in newStick.GetObjects())
                {
                    if((DeviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                    {
                        newStick.GetObjectPropertiesById((int)DeviceObject.ObjectType).SetRange(-100, 100);

                    }
                }
                
                sticks.Add(newStick);
                comboBox1.Items.Add(newDevice.ProductName);
                
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Nie wykryto zadnego urzadzenia");
            }
            
        }

        private void simulateMouse()
        {
            
            newStick = sticks[comboBox1.SelectedIndex];

            JoystickState state = newStick.GetCurrentState();
            joystickButtons = state.GetButtons();
            
            Cursor.Position = new Point(Cursor.Position.X + state.X/3, Cursor.Position.Y + state.Y/3);

            if (joystickButtons[0] == true)
            {
                
                mouse_event(MOUSEEVENT_LEFTDOWN,0,0,0,0);
                leftClick = true;

            }

            if (leftClick == true)
            {
                
                mouse_event(MOUSEEVENT_LEFTUP,0,0,0,0);
                leftClick = false;
                
            }

            if (joystickButtons[1] == true)
            {
                
                mouse_event(MOUSEEVENT_RIGHTDOWN, 0, 0, 0, 0);
                rightClick = true;

            }

            if (rightClick == true)
            {
                
                mouse_event(MOUSEEVENT_RIGHTUP, 0, 0 ,0 ,0);
                rightClick = false;

            }

            if (joystickButtons[2] == true)
            {

                timer1.Enabled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Przycisk '1' -> lewy przycisk myszki, \nPrzycisk '2' -> prawy przycisk myszki \nPrzycisk '3' -> zakoncz symulowanie");
                
            timer1.Enabled = true;

        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            simulateMouse();
        }
    }
    
}