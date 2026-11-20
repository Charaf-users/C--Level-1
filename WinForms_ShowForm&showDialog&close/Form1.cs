using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_ShowForm_showDialog_close
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Tag.ToString();
            string value2=textBox2.Tag.ToString();
            if(value=="charafEddine")
            {
                if(value2=="charafcharaf")
                {
                    Form frm = new Form2();
                    frm.Show();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox1.Tag.ToString();
            string value2 = textBox2.Tag.ToString();
            if (value == "charafEddine")
            {
                if (value2 == "charafcharaf")
                {
                    Form frm = new Form2();
                    frm.ShowDialog();
                }

            }
        }
    }
}
