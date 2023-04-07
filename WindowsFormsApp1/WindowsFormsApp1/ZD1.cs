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
    public partial class ZD1 : Form
    {
        public ZD1()
        {
            InitializeComponent();
        }

        string[] str;
        int[] c = new int[2];
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(';');
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    c[i] = int.Parse(str[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное значеиние");
                return;      
            }

            sum = c.Sum();

            textBox2.Text = sum.ToString();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k!=';' && k!='8')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(button1, "a+b");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
