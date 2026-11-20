using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString(),"Date ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show( dateTimePicker1.Value.ToLongDateString(),"Date ");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-MM-yyyy")+ Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fr = new MonthCalendar();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fr = new Timer();
            fr.ShowDialog();
        }
    }
    }

