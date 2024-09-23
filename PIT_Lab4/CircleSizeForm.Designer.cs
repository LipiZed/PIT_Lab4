using System;
using System.Windows.Forms;

namespace CircleFillApp
{
    partial class CircleSizeForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button okButton;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 22);
            this.textBox1.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(100, 50);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CircleSizeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBox1);
            this.Name = "CircleSizeForm";
            this.Text = "Введите диаметр";
            this.Load += new System.EventHandler(this.CircleSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CircleSizeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
