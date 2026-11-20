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
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" hey i am the message ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey i am the Message ", "send Message");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Confirm",MessageBoxButtons.OK);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                MessageBox.Show("form Completed");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("form Completed","form", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("form  not Completed ,try again!","Annulation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
