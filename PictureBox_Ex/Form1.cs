using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RB_Boy_CheckedChanged(object sender, EventArgs e)
        {
       
               
                pictureBox1.Image = Image.FromFile(@"C:\Images\Boy.png");
                lbName.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void RB_Girl_CheckedChanged(object sender, EventArgs e)
        {
              pictureBox1.Image = Image.FromFile(@"C:\Images\Girl.png");
            lbName.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void RB_Book_CheckedChanged(object sender, EventArgs e)
        {
                
                pictureBox1.Image = Image.FromFile(@"C:\Images\Book.png");
            lbName.Text = ((RadioButton)sender ).Tag.ToString();
        }

        private void RB_Pencil_CheckedChanged(object sender, EventArgs e)
        {
           
                pictureBox1.Image = Image.FromFile(@"C:\Images\Pen.png");
            lbName.Text = ((RadioButton)sender).Tag.ToString();
        }
    }
}
