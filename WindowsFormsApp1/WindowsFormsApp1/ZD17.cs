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
    public partial class ZD17 : Form
    {
        public ZD17()
        {
            InitializeComponent();
        }

        private void paint()
        {
           
        }

        private void ZD17_Load(object sender, EventArgs e)
        {
            int n = 5;
            Graphics graphics = pictureBox1.CreateGraphics();
            PointF[] points = new PointF[2 * n + 1];
            graphics.DrawLines(Pens.Black, points);
        }
    }
}
