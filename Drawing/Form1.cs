using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Drawing_form1(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(white);
            Pen.Width = 13;
            
             Pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
            e.Graphics.DrawLine(Pen, 500, 140, 500, 650);
            e.Graphics.DrawLine(Pen, 700, 140, 700, 650);
           
            e.Graphics.DrawLine(Pen, 300, 300, 900, 300);
            e.Graphics.DrawLine(Pen, 300, 500, 900, 500);


        }

      
    }
}
