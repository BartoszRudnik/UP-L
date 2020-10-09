namespace Bluetooth
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(193, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 404);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 404);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Znalezione urzadzenia";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(79, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Czy zapamietany";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(79, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Czy  zautoryzowany";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 413);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czy polaczono";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(89, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa urzadzenia";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Przeslij plik";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paruj z urzadzeniem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyszukaj urzadzenia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;

        #endregion
    }
}