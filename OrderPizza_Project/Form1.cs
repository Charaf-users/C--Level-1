using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        void UpdateSize()
        {
            UpdateTotalePrice();
            if(RB_Small.Checked)
            {
                LbUpdateSize.Text = "Small";
                return;
            }

            if(RB_Meduim.Checked)
            {
                LbUpdateSize.Text = "Meduim";
                return;
            }
            if(RD_Large.Checked)
            {
                LbUpdateSize.Text = "Large";
                return;
            }
        }
        void UpdateCrust()
        {
            UpdateTotalePrice();
            if(RdThinkCrust.Checked)
            {
                lbCrustType.Text = "Think Crust";
                return;
            }
            if(RdThickCrust.Checked)
            {
                lbCrustType.Text = " Thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalePrice();

            string sToppings = "";

            if(checkBox1.Checked)
            {
                sToppings = "Extra chees";
            }
            if (checkBox2.Checked)
            {
                sToppings += " , Mashrooms";
            }
            if (checkBox3.Checked)
            {
                sToppings += " , Tomatos";
            }
            if (checkBox4.Checked)
            {
                sToppings += " , Onion";
            }
            if (checkBox5.Checked)
            {
                sToppings += " , Olives";
            }
            if (checkBox6.Checked)
            {
                sToppings += " , Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings= sToppings.Substring(1,sToppings.Length-1).Trim();
            }
            if(sToppings=="")
            {
                sToppings = " No Toppings";
            }

            lbToppings.Text = sToppings;

        }

        void WhereToEat()
        {
            if(RdEatIn.Checked)
            {
              Eat.Text = " Eat In";
                return;
            }
            if(RdTakeOut.Checked)
            {
                Eat.Text = "Take Out";
                return;
            }
        }






        float GetSelectedSizePrice()
        {
            if (RB_Small.Checked)
                return Convert.ToSingle(RB_Small.Tag);
            else if (RB_Meduim.Checked)
                return Convert.ToSingle(RB_Meduim.Tag);
            else
                return Convert.ToSingle(RD_Large.Tag);

        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (checkBox1.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox1.Tag);

            }
            if (checkBox2.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox2.Tag);
            }
            if (checkBox3.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox3.Tag);
            }
            if (checkBox4.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox4.Tag);
            }
            if (checkBox5.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox5.Tag);
            }
            if (checkBox6.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(checkBox6.Tag);
            }
            return ToppingsTotalPrice;

        }
        float GetSelectCrustPrice()
        {
            if (RdThickCrust.Checked)
            {
                return Convert.ToSingle(RdThickCrust.Tag);
            }
            else
            
                return Convert.ToSingle(RdThinkCrust.Tag);

            
               
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice()+ CalculateToppingsPrice()+ GetSelectCrustPrice();
        }
        void UpdateTotalePrice()
        {
            LBTotalPrice.Text="$"+CalculateTotalPrice().ToString();
        }

        void ResetForm()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            btnOrderPizza.Enabled = true;

            RB_Meduim.Checked=true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3 .Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            RdEatIn.Checked=true;
            RdThinkCrust.Checked=true;
           
        }


        void UpdateOderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            WhereToEat();
            UpdateTotalePrice();

        }


        private void RB_Small_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RB_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RD_Large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat();
        }
        
         
       
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm your Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show(" Order Placed Successfuly", "Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                btnOrderPizza.Enabled = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            ResetForm();
        }

       

        private void LBTotalPrice_Click(object sender, EventArgs e)
        {
            UpdateTotalePrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOderSummary();
        }
    }
}
