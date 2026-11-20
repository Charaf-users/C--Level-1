using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SecureCrypt_Project
{
    public partial class Form : System.Windows.Forms.Form
    { 
        public Form()
        {
            InitializeComponent();
            timer1.Start();
        }
        string EncryptText(string text,short Key)
        {
           StringBuilder sb = new StringBuilder(text);
            for (int i=0; i<sb.Length; i++)
            {
             

                sb[i] = (char)(sb[i] + Key);

            }
            return  sb.ToString();
        }
        string DescryptionText(string text, short Key)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {


                sb[i] = (char)(sb[i] - Key);

            }
            return sb.ToString();
        }
        
        void EncryptBar()
        {

            lbProgress.Visible = true;
            progressBar1.Visible = true;
            button1.Visible = false;

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i < 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    lbProgress.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    lbProgress.Refresh();
                }
             

            }


        }

        void Encyption()
        { 
           
            short key=short.Parse(trackBar1.Value.ToString());
            textBox2.Text =  EncryptText(textBox1.Text,key );

           
        }
        void Descryption()
        {
            short key = short.Parse(trackBar1.Value.ToString());
            textBox4.Text = DescryptionText(textBox3.Text, key);
        }

        void descryptedBar()
        {
            lbProgress2.Visible = true;
            progressBar2.Visible = true;
            button2.Visible = false;

            progressBar2.Value = 0;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;

            for (int i = 0; i < 10; i++)
            {
                if (progressBar2.Value < progressBar2.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar2.Value += 10;
                    lbProgress2.Text = (((float)progressBar2.Value / progressBar2.Maximum) * 100) + "%";
                    progressBar2.Refresh();
                    lbProgress2.Refresh();
                }
               
                    
                

            }
           

        }
        void Exit()
        {
            if (MessageBox.Show("Are you sure you want exit ", "Cofirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                this.Close();
            }
        }

        void customize()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                


            }
        }
        void changeColor()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
                textBox2.BackColor = colorDialog1.Color;
                textBox3.BackColor = colorDialog1.Color;
                textBox4.BackColor = colorDialog1.Color;

            }
          
        }
        void changeFont()
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox2.Font = fontDialog1.Font;
                textBox3.Font = fontDialog1.Font;
                textBox4.Font = fontDialog1.Font;


            }
         

        }

        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            EncryptBar();
            lbProgress.Visible = false;
            progressBar1.Visible =false;
            button1.Visible = true;
            MessageBox.Show("your text has been encrypted","Encryption", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Encyption();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descryptedBar();
            lbProgress2.Visible = false;
            progressBar2.Visible = false;
            button2.Visible = true;
            MessageBox.Show("your text has been Descrypted","Descryption", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Descryption();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void lbDate_Click(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void lbKey_Click(object sender, EventArgs e)
        {
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbKey.Text = trackBar1.Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customize();
        }

        private void fmchangeColor_Click(object sender, EventArgs e)
        {
            changeColor();



        }

        private void fmChangeFont_Click(object sender, EventArgs e)
        {
            changeFont();
        }

        private void fmClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void fmCopy_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
