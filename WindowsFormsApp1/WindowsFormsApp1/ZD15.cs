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
    public partial class ZD15 : Form
    {
        ToolStripLabel infOdataLabel;

        ToolStripLabel dataLabel;

        ToolStripLabel infOtimeLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD15()
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

        public static int null0=0;

        private void ZD15_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "наименование игрушки");

            dataGridView1.Columns.Add("", "стоимость");

            dataGridView1.Columns.Add("", "производитель");

            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[2].Width = 120;

            srt = File.ReadAllText("сведения.txt");

            int count = dataGridView1.ColumnCount;

            file = srt.Split(' ');

            c = file.Length / count;

            for (int i = 0; i < c; i++)
            {
                dataGridView1.Rows.Add(file[null0], file[null0 + 1], file[null0 + 2]);
                null0 += count;
            }

            timer1.Start();

        }

        string str;

        string[] file;

        string srt;

        string openFile;

        int c = 0;

        private void button4_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;

            str = saveFileDialog1.FileName;

            StreamWriter sw = new StreamWriter(str);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    sw.Write(Convert.ToString(dataGridView1[j, i].Value)+" ");
                }
            }
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Refresh();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = openFileDialog1.FileName;

            srt = File.ReadAllText(openFile);

            int count = dataGridView1.ColumnCount;

            file = srt.Split(' ');

            c = file.Length / count;

            null0 = 0;

            for (int i = 0; i < c; i++)
            {
                dataGridView1.Rows.Add(file[null0], file[null0 + 1], file[null0 + 2]);
                null0 += count;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
