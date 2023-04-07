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
    public partial class ZD7 : Form
    {
        public ZD7()
        {
            InitializeComponent();
        }

        int[,] array = new int[3,3];

        Random Random = new Random();

        private void ZD7_Load(object sender, EventArgs e)
        {
            textBox1.Text += "Матрица:" + "\r\n";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i,j] = Random.Next(-100, 100);

                    textBox1.Text += array[i, j].ToString() + " ";
                }

                textBox1.Text += "\r\n";
            }
        }
    }
}
