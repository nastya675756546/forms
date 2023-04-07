using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class ZD5 : Form
    {
        public ZD5()
        {
            InitializeComponent();
        }

        string dobavit;

        private void button1_Click(object sender, EventArgs e)
        {
            dobavit = Interaction.InputBox
                (
                  "Введите предмет",
                  ""
                );

            if (dobavit != "")
            {
                listBox1.Items.Add(dobavit);

                Program.zd5_1.comboBox1.Items.Add(dobavit);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.zd5_1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Program.zd5_1.comboBox1.Items.Clear();
        }

        string[] array;

        private void button5_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        string str;

        private void button4_Click(object sender, EventArgs e)
        {
            array = new string[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                array[i] = listBox1.Items[i].ToString();
            }


            Array.Sort(array);

            listBox1.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                str = array[i];

                listBox1.Items.Add(str.ToString());
            }
        }
    }
}
