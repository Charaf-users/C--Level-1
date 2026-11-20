using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }
       public  void Addproduct(string product, string price)
        {

            ListViewItem Item = new ListViewItem();
            Item.SubItems.Add(product);
            Item.SubItems.Add(price);
            listView1.Items.Add(Item);
         
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= listView1.Items.Count; i++)
            {
                listView1.Items.ToString();

            }

        }
    }
}
