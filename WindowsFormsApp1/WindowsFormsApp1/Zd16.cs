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
    public partial class Zd16 : Form
    {
        public Zd16()
        {
            InitializeComponent();
            SetSize();
        }

        public bool isMouse = false;

        private Class1 arrayPoints = new Class1(2);

        Bitmap map = new Bitmap(100, 100);

        Graphics graphics;

        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;

            map = new Bitmap(rectangle.Width, rectangle.Height);

            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.Reset();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse)
            {
                return;
            }
            arrayPoints.SetPoint(e.X, e.Y);

            if (arrayPoints.GetCount()>=2)
            {
                graphics.DrawLines(pen,arrayPoints.Get());

                pictureBox1.Image = map;

                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }

            pen.Color = colorDialog1.Color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.pictureBox1.Image = pictureBox1.Image;
        }
    }
}
