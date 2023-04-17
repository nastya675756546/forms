using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ZD11 : Form
    {
        ToolStripLabel infOdataLabel;

        ToolStripLabel dataLabel;

        ToolStripLabel infOtimeLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD11()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            infOdataLabel = new ToolStripLabel();
            infOdataLabel.Text = "Дата:";

            dataLabel = new ToolStripLabel();

            infOtimeLabel = new ToolStripLabel();
            infOtimeLabel.Text = "Время:";

            timeLabel = new ToolStripLabel();

            infOfileLabel = new ToolStripLabel();
            infOfileLabel.Text = "Путь к файлу:";

            fileLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infOdataLabel);

            statusStrip1.Items.Add(dataLabel);

            statusStrip1.Items.Add(infOtimeLabel);

            statusStrip1.Items.Add(timeLabel);

            statusStrip1.Items.Add(infOfileLabel);

            statusStrip1.Items.Add(fileLabel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
        string str = "";

        string file = "";

        string open = "";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            str = openFileDialog1.FileName;

            open = File.ReadAllText(str);

            textBox1.Text = open;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            file = textBox1.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;

            str = saveFileDialog1.FileName;

            File.WriteAllText(str, textBox1.Text);

        }

        private void ZD11_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();

        }
    }
}
