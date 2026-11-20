using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class DialogColor : Form
    {
        public DialogColor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor= colorDialog1.Color; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor= colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowHelp = true;

            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font= fontDialog1.Font;
                textBox1.ForeColor= fontDialog1.Color;
            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:/";
            saveFileDialog1.Title = "Save in";
            saveFileDialog1.DefaultExt= "txt";
            saveFileDialog1.Filter = "txt Files (*.txt)| *.Txt| All Files(*.*) |*.*";
            saveFileDialog1.FilterIndex = 1;

            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
               MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:/";
            openFileDialog1.Title = "Save in";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt Files (*.txt)| *.Txt| All Files(*.*) |*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach(string Files in openFileDialog1.FileNames)
                {
                    MessageBox.Show(Files);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton=true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
