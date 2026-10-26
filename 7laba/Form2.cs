using System;
using System.Windows.Forms;

 namespace _7laba
{
    public partial class Form2 : Form
    {
        // Конструктор формы, который принимает 2 массива
        public Form2(double[] original, double[] smoothed)
        {
            InitializeComponent();

            textBox1.AppendText("Исходный массив:\r\n");
            for (int i = 0; i < original.Length; i++)
                textBox1.AppendText($"A[{i}] = {original[i]:F2}\r\n");

            textBox1.AppendText("\r\nПосле сглаживания:\r\n");
            for (int i = 0; i < smoothed.Length; i++)
                textBox1.AppendText($"A[{i}] = {smoothed[i]:F2}\r\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



     