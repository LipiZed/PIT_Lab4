using System;
using System.Windows.Forms;

namespace CircleFillApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button selectColorButton; // Кнопка для выбора цвета
        private Button changeSizeButton; // Кнопка для изменения размера круга

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.selectColorButton = new System.Windows.Forms.Button();
            this.changeSizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectColorButton
            // 
            this.selectColorButton.Location = new System.Drawing.Point(12, 12);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(120, 40);
            this.selectColorButton.TabIndex = 0;
            this.selectColorButton.Text = "Выбрать цвет";
            this.selectColorButton.UseVisualStyleBackColor = true;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // changeSizeButton
            // 
            this.changeSizeButton.Location = new System.Drawing.Point(150, 12);
            this.changeSizeButton.Name = "changeSizeButton";
            this.changeSizeButton.Size = new System.Drawing.Size(120, 40);
            this.changeSizeButton.TabIndex = 1;
            this.changeSizeButton.Text = "Изменить размер";
            this.changeSizeButton.UseVisualStyleBackColor = true;
            this.changeSizeButton.Click += new System.EventHandler(this.changeSizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeSizeButton);
            this.Controls.Add(this.selectColorButton);
            this.Name = "Form1";
            this.Text = "Рисование кругов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
