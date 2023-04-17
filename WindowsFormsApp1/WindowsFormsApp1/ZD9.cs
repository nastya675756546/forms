using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZD9 : Form
    {
        public ZD9()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ZD9_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "Имя");

            dataGridView1.Columns.Add("", "Фамилия");

            dataGridView1.Columns.Add("", "Класс");

            dataGridView1.Columns.Add("", "Средний балл");
        }

        string[] a;

        string[] b;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            textBox1.Clear();

            a = new string[dataGridView1.RowCount];

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                a[j] = Convert.ToString(dataGridView1[1, j].Value);

                textBox2.Text += a[j];
            }

            b = a.Distinct().ToArray();

            for (int i = 0; i < b.Length; i++)
            {
                textBox1.Text += b[i];
            }

            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("В школе нет однофамильцев");
            }
            else
            {
                MessageBox.Show("В школе есть однофамильцы");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
