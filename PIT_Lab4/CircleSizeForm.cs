using System;
using System.Windows.Forms;

namespace CircleFillApp
{
    public partial class CircleSizeForm : Form
    {
        public int CircleDiameter { get; private set; } // Свойство для хранения диаметра

        public CircleSizeForm(int currentDiameter)
        {
            InitializeComponent();
            textBox1.Text = currentDiameter.ToString(); // Устанавливаем текущее значение диаметра
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Валидация ввода
            if (int.TryParse(textBox1.Text, out int diameter) && diameter > 0)
            {
                CircleDiameter = diameter; // Сохраняем диаметр
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите корректное положительное число.");
            }
        }
    }
}
