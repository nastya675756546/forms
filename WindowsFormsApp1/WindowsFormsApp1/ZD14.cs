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
    public partial class ZD14 : Form
    {
        public ZD14()
        {
            InitializeComponent();
        }

        private void ZD14_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "наименование игрушки");

            dataGridView1.Columns.Add("", "стоимость");

            dataGridView1.Columns.Add("", "производитель");

            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[2].Width = 120;

            dataGridView1.Rows.Add("Мишка", "565 р.", " OOO \"Игрушки\" ");

            dataGridView1.Rows.Add("Неволяшка", "547 р.", " OOO \"Игрушки\" ");

            dataGridView1.Rows.Add("Машинка", "346 р.", " OOO \"Бегемот\" ");

            dataGridView1.Rows.Add("Мишка", "128 р.", " OOO \"Бегемот\" ");

            comboBox1.Items.Add(postavshik1);

            comboBox1.Items.Add(postavshik2);

        }

        string postavshik1 = " OOO \"Игрушки\" ";

        string postavshik2 = " OOO \"Бегемот\" ";

        string postavshik;

        private void button1_Click(object sender, EventArgs e)
        {
            postavshik = comboBox1.Text;

            if (postavshik==postavshik1)
            {
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Rows.RemoveAt(3);
            }
            if (postavshik==postavshik2)
            {
                dataGridView1.Rows.RemoveAt(0);
                dataGridView1.Rows.RemoveAt(1);
            }
            if (postavshik!=postavshik1 && postavshik!=postavshik2)
            {
                MessageBox.Show("Неверный ввод");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
