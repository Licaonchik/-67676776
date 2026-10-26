using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Введите положительное число N!");
                return;
            }

            dGVInput.Rows.Clear();
            dGVInput.Columns.Clear();
            dGVInput.Columns.Add("index", "Индекс");
            dGVInput.Columns.Add("value", "Значение");

            for (int i = 0; i < N; i++)
                dGVInput.Rows.Add(i, "0");

            dGVInput.AllowUserToAddRows = false;
        }

        
            private void btnSmooth_Click(object sender, EventArgs e)
        {
            int N = dGVInput.Rows.Count;
            if (N < 3)
            {
                MessageBox.Show("Сначала создайте массив (минимум 3 элемента)!");
                return;
            }

            // Читаем числа из таблицы
            double[] original = new double[N];
            for (int i = 0; i < N; i++)
                original[i] = double.Parse(dGVInput.Rows[i].Cells[1].Value.ToString());

            // Сглаживаем
            double[] smoothed = (double[])original.Clone();
            for (int i = 1; i < N - 1; i++)
                smoothed[i] = (original[i - 1] + original[i] + original[i + 1]) / 3.0;

            // Открываем вторую форму и передаем туда массивы
            Form2 f2 = new Form2(original, smoothed);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

