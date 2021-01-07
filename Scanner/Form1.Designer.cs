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
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Size = new System.Drawing.Size(581, 606);
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
            this.button2.Location = new System.Drawing.Point(12, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Skanuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 568);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 630);
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
            this.ResumeLayout(false);
        }

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