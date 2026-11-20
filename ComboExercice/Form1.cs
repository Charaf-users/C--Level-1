using ComboExercice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboExercice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Resources.Book;
                lbName.Text = "Book";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Resources.Boy;
                lbName.Text = "Boy";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Resources.Girl;
                lbName.Text = "Girl";
            }
            else
            {
                pictureBox1.Image = Resources.Pen;
                lbName.Text = "Pencil";

            }


        }

       
    }
}
