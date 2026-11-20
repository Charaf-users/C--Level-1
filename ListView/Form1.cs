using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(TxtName.Text))
                return;
            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if(rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(TxtName.Text.Trim());
            listView1.Items.Add(item);
            txtID.Clear();
            TxtName.Clear();
            txtID.Focus();

            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void btnFileRandomly_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=10;i++)
            {
                ListViewItem Item=new ListViewItem(i.ToString());
                if(i%2==0)
                    Item.ImageIndex = 0;
                else Item.ImageIndex = 1;
                Item.SubItems.Add("Person " + i);
                listView1.Items.Add(Item);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
