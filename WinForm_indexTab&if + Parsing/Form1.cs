using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_indexTab_if___Parsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int age))
            {
                if(age>=18)
                {
                    MessageBox.Show("Your are Adult", "Validation");
                }
                else
                {
                    MessageBox.Show("Your are Minor", "Validation");

                }
            }
            else
            {
                MessageBox.Show("Invalid Choice");
            }
        }
    }
}
