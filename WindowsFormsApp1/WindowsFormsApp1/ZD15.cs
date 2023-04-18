using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ZD15 : Form
    {
        public ZD15()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void ZD15_Load(object sender, EventArgs e)
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

        }

        string str;

        private void button4_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;

            str = saveFileDialog1.FileName;

            StreamWriter sw = new StreamWriter(str);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    sw.Write(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            sw.Close();
        }

        int count = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns.RemoveAt(count);
                count++;
            }
            

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            str = openFileDialog1.FileName;

            open = File.ReadAllText(str);

            textBox1.Text = open;
        }
    }
}
