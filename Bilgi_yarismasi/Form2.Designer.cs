﻿namespace Bilgi_yarismasi
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 252);
            button1.Name = "button1";
            button1.Size = new Size(201, 93);
            button1.TabIndex = 0;
            button1.Text = "Yarışmaya Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 56);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 1;
            label1.Text = "Merhaba! Ben Furkan Yılmaz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 94);
            label2.Name = "label2";
            label2.Size = new Size(481, 20);
            label2.TabIndex = 2;
            label2.Text = "Akdeniz Üniversitesi'nde Yönetim Bilişim Sistemleri 1. sınıf öğrencisiyim.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 130);
            label3.Name = "label3";
            label3.Size = new Size(606, 20);
            label3.TabIndex = 3;
            label3.Text = "Bu yarışmayı hazırlarken yapay zeka teknolojilerinden de faydalandım umarım eğlenirsiniz.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 169);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 4;
            label4.Text = "Herkese başarılar!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}