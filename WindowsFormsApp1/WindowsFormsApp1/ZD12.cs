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
    public partial class ZD12 : Form
    {

        ToolStripLabel infOdataLabel;

        ToolStripLabel dataLabel;

        ToolStripLabel infOtimeLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD12()
        {
            InitializeComponent();

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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();
        }

        private void ZD12_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public static string fileName = "Untitled";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            textBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                
                try
                {
                    using (StreamReader reader = File.OpenText(fileName))
                    {
                        textBox1.Clear();
                        textBox1.Text = reader.ReadToEnd();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "Untitled")
                saveAsToolStripMenuItem_Click(sender, e);
            else
            {
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBox1.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Untitled";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
               
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBox1.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}
