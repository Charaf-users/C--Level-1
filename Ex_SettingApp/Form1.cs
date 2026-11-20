using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_SettingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Age()
        {
            if(numericUpDown1.Value>=18)
            {
                lbAge.Text = numericUpDown1.Value.ToString();
            }
           

        }
        void Display()
        {
            if(numericUpDown2.Value>0)
            {
                lbLevel.Text = numericUpDown2.Value.ToString()+"%";
            }
        }

        void Reset()
        {
            numericUpDown2.Value = 50;
            numericUpDown1.Value = 18;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Age();

        }

         

       

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Display();
        }
    }
}
