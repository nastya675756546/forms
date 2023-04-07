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
    public partial class ZD6 : Form
    {
        public ZD6()
        {
            InitializeComponent();
        }

        string []massiv = new string [10];

        int[] array;

        int k;

        private void button1_Click(object sender, EventArgs e)
        {
            k = 0;

            massiv = textBox1.Text.Split(';');

            if (massiv.Length == 10)
            {
                array = new int[massiv.Length];

                for (int i = 0; i < massiv.Length; i++)
                {
                    try
                    {
                        array[i] = int.Parse(massiv[i]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введите 10 чисел через ;");
                        return;
                    }
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        k += array[i];
                    }
                }

                textBox2.Text = k.ToString();
            }
            else
            {
                MessageBox.Show("Введите 10 чисел");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!char.IsDigit(k) && k != '-' && k != 8 && k != ';')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
