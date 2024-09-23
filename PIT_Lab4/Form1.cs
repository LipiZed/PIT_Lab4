using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CircleFillApp
{
    public partial class Form1 : Form
    {
        private List<Circle> circles; // Список кругов для рисования
        private Color currentFillColor; // Текущий цвет заливки
        private int currentDiameter = 100; // Текущий диаметр круга
        private bool isColorSelected = false; // Флаг выбора цвета

        public Form1()
        {
            InitializeComponent();
            circles = new List<Circle>();
            currentFillColor = Color.Blue;
            this.DoubleBuffered = true;
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isColorSelected)
                {
                    MessageBox.Show("Пожалуйста, выберите цвет перед созданием круга.");
                    return;
                }

                Circle circle = new Circle
                {
                    X = e.X - currentDiameter / 2,
                    Y = e.Y - currentDiameter / 2,
                    Diameter = currentDiameter,
                    FillColor = currentFillColor
                };
                circles.Add(circle);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var circle in circles)
            {
                using (Brush brush = new SolidBrush(circle.FillColor))
                {
                    g.FillEllipse(brush, circle.X, circle.Y, circle.Diameter, circle.Diameter);
                }
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    g.DrawEllipse(pen, circle.X, circle.Y, circle.Diameter, circle.Diameter);
                }
            }
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFillColor = colorDialog.Color;
                    isColorSelected = true;
                }
            }
        }

        // Обработка нажатия кнопки для изменения размера круга
        private void changeSizeButton_Click(object sender, EventArgs e)
        {
            using (CircleSizeForm sizeForm = new CircleSizeForm(currentDiameter))
            {
                if (sizeForm.ShowDialog() == DialogResult.OK)
                {
                    currentDiameter = sizeForm.CircleDiameter;
                }
            }
        }
    }

    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Diameter { get; set; }
        public Color FillColor { get; set; }
    }
}
