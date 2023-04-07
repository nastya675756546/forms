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
    public partial class ZD3 : Form
    {
        public ZD3()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        string[] str;

        int[] n = new int[3];

        int sum = 0;

        int raz = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(';');

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    n[i] = int.Parse(str[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное значеиние");
                return;
            }

            if (n[0] > n[1] && n[1] > n[2])
            {
                textBox2.Text += n[0].ToString() + ";";
                textBox2.Text += n[1].ToString();
                sum = n[0] + n[1];
                raz = n[0] - n[1];
            }
            if (n[0] > n[2] && n[2] > n[1])
            {
                textBox2.Text += n[0].ToString() + ";";
                textBox2.Text += n[2].ToString();
                sum = n[0] + n[2];
                raz = n[0] - n[2];
            }
            if (n[1] > n[0] && n[0] > n[2])
            {
                textBox2.Text += n[0].ToString() + ";";
                textBox2.Text += n[1].ToString();
                sum = n[0] + n[1];
                raz = n[1] - n[0];
            }
            if (n[1] > n[2] && n[2] > n[0])
            {
                textBox2.Text += n[1].ToString() + ";";
                textBox2.Text += n[2].ToString();
                sum = n[2] + n[1];
                raz = n[1] - n[2];
            }
            if (n[2] > n[0] && n[0] > n[1])
            {
                textBox2.Text += n[0].ToString() + ";";
                textBox2.Text += n[2].ToString();
                sum = n[0] + n[2];
                raz = n[2] - n[0];
            }
            if (n[2] > n[1] && n[1] > n[0])
            {
                textBox2.Text += n[2].ToString() + ";";
                textBox2.Text += n[1].ToString();
                sum = n[2] + n[1];
                raz = n[2] - n[1];
            }

            textBox3.Text = sum.ToString();
            textBox4.Text = raz.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
