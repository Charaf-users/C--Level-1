using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_OrderProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         void selectProduct()
        {
            if(comboBox1.SelectedIndex==0)
            {
                lbProductSelected.Text = "Phone";
                comboBox1.Tag = 200;
                CalculateTotalPrice();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                lbProductSelected.Text = "Laptop";
                comboBox1.Tag = 600;
                CalculateTotalPrice();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                lbProductSelected.Text = "Headphone";
                comboBox1.Tag = 50;
                CalculateTotalPrice();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                lbProductSelected.Text = "speaker";
                comboBox1.Tag = 60;
                CalculateTotalPrice();
            }
        }
        void Quantité()
        {
            lbQuantity.Text=numericUpDown1.Value.ToString();
        }
        void CalculateTotalPrice()
        {
            int total = 0;
            int price = int.Parse(comboBox1.Tag.ToString());
            int quantite= int.Parse(numericUpDown1.Value.ToString());
            total = price * quantite;
            lbTotalPrice.Text = total.ToString();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        void AddToCart()
        {
            tabControl1.SelectedIndex = 1;
            selectProduct();
            Quantité();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
