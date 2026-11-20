using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;

        }

        private void Mouse_enter(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button7.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
           
            button7.Enabled =  true;
            button2.Enabled =  true;
            button3.Enabled =  true;
            button4.Enabled =  true;
            button6.Enabled =  true;
            button9.Enabled =  true;
            button8.Enabled =  true;
            button10.Enabled = true;
            button11.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            this.BackColor= Color.Aqua;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Text = " Charaf Form";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "Practical Project :";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            Form frm2 = new MessageBoxForm();
            frm2.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form3();
            frm2.ShowDialog();
        }
    }
}
