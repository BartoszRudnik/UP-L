﻿namespace KartaMuzyczna
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Timers.Timer();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wczytaj plik *.WAV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WczytajButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 347);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naglowek wczytanego pliku";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(275, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "System.Media.SoundPlayer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start Player\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SystemMediaSoundPlayer_Start);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Stop Player";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SystemMediaSoundPlayer_Stop);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(275, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Windows Media Player (*.wav)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "Start Player";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WMP_WAV_Start);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(394, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 8;
            this.button5.Text = "Stop Player";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.WMP_WAV_STOP);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(275, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Windows Media Player (*.mp3)";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(273, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 10;
            this.button6.Text = "Start Player";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.WMP_MP3_Start);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(394, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 28);
            this.button7.TabIndex = 11;
            this.button7.Text = "Stop Player";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.WMP_MP3_Stop);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(275, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "nAudio\r\n";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(275, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = "Start Player";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.nAudio_Start);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(394, 261);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 25);
            this.button9.TabIndex = 14;
            this.button9.Text = "Stop Player";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.nAudio_Stop);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(275, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "PlaySound()";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(275, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 33);
            this.button10.TabIndex = 16;
            this.button10.Text = "Start Player";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.PlaySound_Start);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(394, 330);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 33);
            this.button11.TabIndex = 17;
            this.button11.Text = "Stop Player";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.PlaySound_Stop);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(275, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "DirectSound";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(275, 406);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 35);
            this.button12.TabIndex = 19;
            this.button12.Text = "Start Player";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.DirectSound_Start);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(394, 406);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 35);
            this.button13.TabIndex = 20;
            this.button13.Text = "Stop Player";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.DirectSound_Stop);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(687, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(142, 46);
            this.button14.TabIndex = 22;
            this.button14.Text = "Wybierz lokalizacja zapisu";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(603, 218);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(142, 48);
            this.button15.TabIndex = 23;
            this.button15.Text = "Rozpocznij nagrywanie";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.recordAudio_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(775, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dostepne mikrofony";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(603, 12);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(142, 50);
            this.button16.TabIndex = 26;
            this.button16.Text = "Wyszukaj Mikrofony";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.searchMicrophones_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(777, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(777, 218);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(142, 48);
            this.button17.TabIndex = 28;
            this.button17.Text = "Zakoncz nagrywanie";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.stopRecording_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(777, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 53);
            this.textBox2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(615, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status Nagrywania";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(777, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Moc odtwarzania";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(603, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 35;
            this.label10.Text = "Wybierz urzadzenie";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(775, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(603, 333);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 24);
            this.comboBox2.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(394, 466);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(187, 24);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(273, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Wybierz efekt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 501);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button button17;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button button16;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button button15;

        private System.Windows.Forms.Button button14;

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button button9;

        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}