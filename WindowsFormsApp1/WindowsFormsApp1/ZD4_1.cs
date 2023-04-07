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
    public partial class ZD4_1 : Form
    {
        public ZD4_1()
        {
            InitializeComponent();
        }

        public static string str;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;

            if (str!="")
            {
                Program.zd4.listBox1.Items.Add(str);

                Program.zd4_2.comboBox1.Items.Add(str);
            }

            textBox1.Clear();

            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!( k >= 'А' && k <= 'я') && k != ' ' && k != 8)
            {
                e.Handled = true;
            }
        }
    }
}
