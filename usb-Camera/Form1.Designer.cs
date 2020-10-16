namespace usb_Camera
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Web.UI.WebControls.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Web.UI.WebControls.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Rozdzielczosc = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Web.UI.MobileControls.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz zdjecie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(731, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lokalizacja pliku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 649);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz urzadzenie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 549);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start kamera";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(422, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Stop kamera";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 627);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 44);
            this.button5.TabIndex = 9;
            this.button5.Text = "Wybierz lokalizacje pliku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(90, 627);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 44);
            this.button6.TabIndex = 10;
            this.button6.Text = "Start nagrywanie";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(188, 627);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 44);
            this.button7.TabIndex = 11;
            this.button7.Text = "Stop nagrywanie";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 15;
            this.trackBar1.Location = new System.Drawing.Point(1027, 50);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Minimum = -1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1027, 115);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Minimum = -255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 56);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1027, 186);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Minimum = -255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 56);
            this.trackBar3.SmallChange = 5;
            this.trackBar3.TabIndex = 14;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(946, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nasycenie";
            // 
            // label4
            // 
            this.label4.ID = null;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(946, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Jasnosc";
            // 
            // label6
            // 
            this.label6.ID = null;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(946, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kontrast";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Reset nasycenie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1039, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 42);
            this.button8.TabIndex = 19;
            this.button8.Text = "Reset jasnosc";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1137, 236);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 42);
            this.button9.TabIndex = 20;
            this.button9.Text = "Reset kontrast";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Rozdzielczosc
            // 
            this.Rozdzielczosc.FormattingEnabled = true;
            this.Rozdzielczosc.ItemHeight = 16;
            this.Rozdzielczosc.Location = new System.Drawing.Point(946, 298);
            this.Rozdzielczosc.Name = "Rozdzielczosc";
            this.Rozdzielczosc.Size = new System.Drawing.Size(275, 180);
            this.Rozdzielczosc.TabIndex = 21;
            this.Rozdzielczosc.SelectedIndexChanged += new System.EventHandler(this.Rozdzielczosc_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(946, 484);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 23);
            this.button10.TabIndex = 22;
            this.button10.Text = "Zmien rozdzielczosc";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1107, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.DeviceSpecific = null;
            this.textBox3.ID = null;
            this.textBox3.Text = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1080, 571);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(946, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Detekcja ruchu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 680);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.Rozdzielczosc);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label8;
        private System.Web.UI.MobileControls.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button button10;

        private System.Windows.Forms.ListBox Rozdzielczosc;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

        private System.Windows.Forms.Label label3;
        private System.Web.UI.WebControls.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Web.UI.WebControls.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}