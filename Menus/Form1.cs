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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form fr = new AddProduct();
        Form fr2 = new ViewProduct();

        
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr.MdiParent = this;
            fr.Show();

        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr2.MdiParent = this;
            fr2.Show();
        }
    }
}
