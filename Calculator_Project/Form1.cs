using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            Tb1.Clear();
            tb2.Clear();

        }

        float num1;
        float num2;
        string opeartor = "";

     
        void Historique()
        {
            tb2.Text= Tb1.Text ;
        }
   
       
        void GetValue(Button btn)
        {
            

            Tb1.Text += btn.Tag.ToString();
            
           
        }
       void setOperator(Button btn)
        {
            num1 = float.Parse(Tb1.Text);
            opeartor=btn.Tag.ToString();
            Tb1.Clear();

        }
        void Delete()
        {

            if (!string.IsNullOrEmpty(Tb1.Text))
            {

                Tb1.Text = Tb1.Text.Remove(Tb1.Text.Length - 1);
            }
        }
       

        void Calcule()
        {
          
           num2= float.Parse(Tb1.Text);
           
            float result=0;
            switch(opeartor)
            {
                case "+":
                    {
                        result=num1 + num2;
                        break;
                    }
                case "-":
                    {
                        result = num1 - num2;
                        break;
                    }
                case "X":
                    {
                        result = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        result = num1 / num2;
                        break;
                    }
                case "%":
                    {
                        result = num1 % num2;
                        break;
                    }
            }

           
            lbResult.Text="= "+ result.ToString();
            Tb1.Text = Convert.ToString(num1 + opeartor + num2);




        }
    

        private void btnAC_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            Historique();
        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {
            
            Historique();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
           

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            GetValue((Button)sender);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            setOperator((Button)sender);

        }

        private void btnMood_Click(object sender, EventArgs e)
        {

            setOperator((Button)sender);

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            setOperator((Button)sender);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            setOperator((Button)sender);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            setOperator((Button)sender);
        }

        private void bbtnSum_Click(object sender, EventArgs e)
        {
            setOperator((Button)sender);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Calcule();
        }

        private void lbResult_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
