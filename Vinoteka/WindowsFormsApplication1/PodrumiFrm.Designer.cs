﻿namespace WindowsFormsApplication1
{
    partial class PodrumiFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodrumiFrm));
            this.adresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brojmjesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adresa
            // 
            this.adresa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adresa.Location = new System.Drawing.Point(121, 41);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(176, 20);
            this.adresa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresa";
            // 
            // brojmjesta
            // 
            this.brojmjesta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brojmjesta.Location = new System.Drawing.Point(121, 80);
            this.brojmjesta.Name = "brojmjesta";
            this.brojmjesta.Size = new System.Drawing.Size(176, 20);
            this.brojmjesta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj mjesta";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(26, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(26, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dodaj podrum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.podrum;
            this.pictureBox1.Location = new System.Drawing.Point(318, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // PodrumiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brojmjesta);
            this.Controls.Add(this.label1);
            this.Name = "PodrumiFrm";
            this.Text = "Podrumi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brojmjesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}