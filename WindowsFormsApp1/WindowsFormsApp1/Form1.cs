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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вычисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd1.Show();
            this.Hide();
        }

        private void вычисленияВыраженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd2.Show();
            this.Hide();
        }

        private void лБ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd3.Show();
            this.Hide();
        }

        private void лБ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd4.Show();
            this.Hide();
        }

        private void лБ4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd5.Show();
            this.Hide();
        }

        private void лБ56ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd6.Show();
            this.Hide();
        }

        private void лР7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd7.Show();
            this.Hide();
        }
    }
}
