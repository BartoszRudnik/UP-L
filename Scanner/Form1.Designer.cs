namespace Scanner
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButtonTIFF = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonJPEG = new System.Windows.Forms.RadioButton();
            this.radioButtonBMP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRozdzielczosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSzerokosc = new System.Windows.Forms.TextBox();
            this.textBoxWysokosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Znajdz urzadzenia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 691);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Skanuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wybierz lokalizacje zapisu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButtonTIFF
            // 
            this.radioButtonTIFF.Location = new System.Drawing.Point(12, 205);
            this.radioButtonTIFF.Name = "radioButtonTIFF";
            this.radioButtonTIFF.Size = new System.Drawing.Size(104, 24);
            this.radioButtonTIFF.TabIndex = 5;
            this.radioButtonTIFF.TabStop = true;
            this.radioButtonTIFF.Text = "TIFF";
            this.radioButtonTIFF.UseVisualStyleBackColor = true;
            this.radioButtonTIFF.CheckedChanged += new System.EventHandler(this.radioButtonTIFF_CheckedChanged);
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.Location = new System.Drawing.Point(17, 164);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(104, 24);
            this.radioButtonPNG.TabIndex = 6;
            this.radioButtonPNG.TabStop = true;
            this.radioButtonPNG.Text = "PNG";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            this.radioButtonPNG.CheckedChanged += new System.EventHandler(this.radioButtonPNG_CheckedChanged);
            // 
            // radioButtonJPEG
            // 
            this.radioButtonJPEG.Location = new System.Drawing.Point(137, 164);
            this.radioButtonJPEG.Name = "radioButtonJPEG";
            this.radioButtonJPEG.Size = new System.Drawing.Size(104, 24);
            this.radioButtonJPEG.TabIndex = 7;
            this.radioButtonJPEG.TabStop = true;
            this.radioButtonJPEG.Text = "JPEG";
            this.radioButtonJPEG.UseVisualStyleBackColor = true;
            this.radioButtonJPEG.CheckedChanged += new System.EventHandler(this.radioButtonJPEG_CheckedChanged);
            // 
            // radioButtonBMP
            // 
            this.radioButtonBMP.Location = new System.Drawing.Point(137, 205);
            this.radioButtonBMP.Name = "radioButtonBMP";
            this.radioButtonBMP.Size = new System.Drawing.Size(104, 24);
            this.radioButtonBMP.TabIndex = 8;
            this.radioButtonBMP.TabStop = true;
            this.radioButtonBMP.Text = "BMP";
            this.radioButtonBMP.UseVisualStyleBackColor = true;
            this.radioButtonBMP.CheckedChanged += new System.EventHandler(this.radioButtonBMP_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wybierz format skanowania";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rozdzielczosc";
            // 
            // textBoxRozdzielczosc
            // 
            this.textBoxRozdzielczosc.Location = new System.Drawing.Point(118, 257);
            this.textBoxRozdzielczosc.Name = "textBoxRozdzielczosc";
            this.textBoxRozdzielczosc.Size = new System.Drawing.Size(123, 22);
            this.textBoxRozdzielczosc.TabIndex = 11;
            this.textBoxRozdzielczosc.TextChanged += new System.EventHandler(this.textBoxRozdzielczosc_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Szerokosc skanowania";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wysokosc skanowania";
            // 
            // textBoxSzerokosc
            // 
            this.textBoxSzerokosc.Location = new System.Drawing.Point(118, 295);
            this.textBoxSzerokosc.Name = "textBoxSzerokosc";
            this.textBoxSzerokosc.Size = new System.Drawing.Size(124, 22);
            this.textBoxSzerokosc.TabIndex = 14;
            this.textBoxSzerokosc.TextChanged += new System.EventHandler(this.textBoxSzerokosc_TextChanged);
            // 
            // textBoxWysokosc
            // 
            this.textBoxWysokosc.Location = new System.Drawing.Point(118, 341);
            this.textBoxWysokosc.Name = "textBoxWysokosc";
            this.textBoxWysokosc.Size = new System.Drawing.Size(123, 22);
            this.textBoxWysokosc.TabIndex = 15;
            this.textBoxWysokosc.TextChanged += new System.EventHandler(this.textBoxWysokosc_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wybierz rodzaj skanowania";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 443);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(17, 559);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 56);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(201, 559);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(173, 56);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jasnosc skanowania";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(201, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kontrast skanowania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 715);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWysokosc);
            this.Controls.Add(this.textBoxSzerokosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRozdzielczosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBMP);
            this.Controls.Add(this.radioButtonJPEG);
            this.Controls.Add(this.radioButtonPNG);
            this.Controls.Add(this.radioButtonTIFF);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox textBoxWysokosc;

        private System.Windows.Forms.TextBox textBoxRozdzielczosc;
        private System.Windows.Forms.TextBox textBoxSzerokosc;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RadioButton radioButtonBMP;

        private System.Windows.Forms.RadioButton radioButtonTIFF;

        private System.Windows.Forms.RadioButton radioButtonJPEG;

        private System.Windows.Forms.RadioButton radioButtonPNG;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}