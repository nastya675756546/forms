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
    public partial class ZD13 : Form
    {
        ToolStripLabel infOdataLabel;

        ToolStripLabel dataLabel;

        ToolStripLabel infOtimeLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD13()
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

        private void button11_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        string[] str;

        private void ZD13_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //button8.Enabled = false;

            button9.Enabled = false;

            button10.Enabled = false;

            
           
        }

        string saveFile = "";

        string text = "";

        private void button10_Click(object sender, EventArgs e)
        {

            button8.Enabled = true;

            button9.Enabled = true;

            text = textBox2.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            saveFile = saveFileDialog1.FileName;

            File.WriteAllText(saveFile, textBox2.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (textBox2.Lines.Length >= 15)
            {
                button10.Enabled = true;
            }*/
        }

        string openFile = "";

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = openFileDialog1.FileName;

            text = File.ReadAllText(openFile);

            textBox2.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();

            comboBox2.Items.Clear();

            str = textBox2.Text.Split(' ', ';', '.', ',');

            var clone = str.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            clons = String.Join(",", clone);

            pouck = clons.Split(',');

            for (int i = 0; i < pouck.Length; i++)
            {
                comboBox2.Items.Add(pouck[i].ToString());
            }
        }

        string clons;
        string[] pouck;

        string word;

        int count = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            word = comboBox2.Text;
            textBox2.Text += word;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==word)
                {
                    count += count;
                }
            }
            textBox2.Text += count.ToString();
            
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
