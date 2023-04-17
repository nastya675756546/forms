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
    public partial class ZD10 : Form
    {
        public ZD10()
        {
            InitializeComponent();
        }

        double a1 = 6.5;

        double a2 = 13.4;

        double a3 = 15.5;

        double b1 = 3.4;

        double b2 = 8.3;

        double b3 = 8.4;

        double h1 = 2.5;

        double h2 = 5.7;

        double h3 = 6.5;

        double s1 ;

        double s2 ;

        double s3 ;

        private void ZD10_Load(object sender, EventArgs e)
        {
            s1 = Class1.S(a1, b1, h1);

            s2 = Class1.S(a2, b2, h2);

            s3 = Class1.S(a3, b3, h3);

            textBox1.Text = s1.ToString();

            textBox4.Text = s2.ToString();

            textBox5.Text = s3.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "1/2(a+b)h");
        }

        private void textBox4_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox4, "1/2(a+b)h");
        }

        private void textBox5_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox5, "1/2(a+b)h");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
