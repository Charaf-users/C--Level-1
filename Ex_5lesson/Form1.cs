using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_5lesson
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            foreach (TreeNode Item in e.Node.Nodes)
            {
                ListViewItem item = new ListViewItem(Item.Text);
                item.ImageIndex = Item.ImageIndex;
                listView1.Items.Add(item);
            }
            CheckTreeViewNode(e.Node, e.Node.Checked);
            errorProvider1.SetError(treeView1, "Please chose folder");
        }
        private void CheckTreeViewNode(TreeNode Node, Boolean isChecked)
        {
            foreach (TreeNode item in Node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            imageList1.ImageSize= new Size(trackBar1.Value, trackBar1.Value);
        }
    }
}
