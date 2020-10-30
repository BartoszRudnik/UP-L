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

        private Pen pen;
        private Graphics g;
        private DirectInput directInput = new DirectInput();
        private SlimDX.DirectInput.Joystick newStick;
        private List <Joystick> sticks = new List<Joystick>();
        private bool[] joystickButtons;
        private bool leftClick = false;
        private bool rightClick = false;
        private bool painting = false;
        private int countLeft = 0;
        private int countRight = 0;
        private int xPaint = 0;
        private int yPaint = 0;
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint flag, uint _x, uint _y, uint btn, uint exinfo);
        private const int MOUSEEVENT_LEFTDOWN = 0X02;
        private const int MOUSEEVENT_LEFTUP = 0X04;
        private const int MOUSEEVENT_RIGHTDOWN = 0X08;
        private const int MOUSEEVENT_RIGHTUP = 0X10;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "0 razy";
            textBox2.Text = "0 razy";
            textBox4.Text = "Wylaczony";
            
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

            int actualX = Cursor.Position.X + state.X / 6;
            int actualY = Cursor.Position.Y + state.Y / 6;
            
            Cursor.Position = new Point(actualX, actualY);

            textBox3.Text = "X: " + actualX.ToString() + " Y: " + actualY.ToString();
            
            if (joystickButtons[0] == true)
            {

                leftClick = true;
                mouse_event(MOUSEEVENT_LEFTDOWN, (uint) actualX, (uint) actualY,0,0);

            }

            if (leftClick == true && joystickButtons[0] == false)
            {
                
                countLeft++;
                textBox1.Text = countLeft.ToString();

                if (countLeft == 1)
                    textBox1.Text += " raz";
                else
                {
                    textBox1.Text += " razy";
                }
                
                mouse_event(MOUSEEVENT_LEFTUP,0,0,0,0);
                leftClick = false;

            }

            if (joystickButtons[1] == true)
            {
                
                panel1.Invalidate();
                rightClick = true;
                mouse_event(MOUSEEVENT_RIGHTDOWN, 0, 0, 0, 0);

            }

            if (rightClick == true && joystickButtons[1] == false)
            {
                
                countRight++;
                textBox2.Text = countRight.ToString();

                if (countRight == 1)
                {
                    textBox2.Text += " raz";
                }
                else
                {
                    textBox2.Text += " razy";
                }
                
                mouse_event(MOUSEEVENT_RIGHTUP, 0, 0 ,0 ,0);
                rightClick = false;

            }

            if (joystickButtons[2] == true)
            {

                timer1.Enabled = false;
                clearCountBoxes();

            }

        }

        private void clearCountBoxes()
        {
            
            countLeft = 0;
            countRight = 0;
            
            textBox1.Text = "0 razy";
            textBox2.Text = "0 razy";
            textBox3.Clear();
            textBox4.Text = "Wylaczony";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Text = "Wlaczony";
            timer1.Enabled = true;

        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            simulateMouse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk '1' -> lewy przycisk myszki, rysowanie \nPrzycisk '2' -> prawy przycisk myszki, czyszczenie rysunku \nPrzycisk '3' -> zakoncz symulowanie");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (painting == true && xPaint != -1 && yPaint != -1)
            {
                
                g.DrawLine(pen, new Point(xPaint, yPaint), new Point(xPaint + 1, yPaint + 1));

                xPaint = e.X;
                yPaint = e.Y;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            painting = false;
            xPaint = -1;
            yPaint = -1;
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            painting = true;
            xPaint = e.X;
            yPaint = e.Y;
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel2.BackColor;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel3.BackColor;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel4.BackColor;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel6.BackColor;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel5.BackColor;
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = panel7.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            clearCountBoxes();

        }
    }
    
}