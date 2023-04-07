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
    public partial class ZD2 : Form
    {
        public ZD2()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        string[] str;

        double[] y;

        double valueY = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(';');

            y = new double [5];

            try
            {
                for (int i = 0; i < y.Length; i++)
                {
                    y[i] = double.Parse(str[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное значеиние");
                return;
            }

            valueY = Math.Round(((y[0] + y[1]) * (y[3] * y[3] + y[4] * y[4])) / ((y[3] - y[2]) * Math.Atan2(y[3], y[2])),3);

            textBox2.Text = valueY.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != ';')
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
