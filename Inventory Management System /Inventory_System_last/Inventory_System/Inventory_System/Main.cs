using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproduct frmproductchild=new frmproduct();
            // Set the Parent Form of the Child window.
            frmproductchild.MdiParent = this;
            // Display the new form.
            frmproductchild.Show();
        }

    

        private void Main_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuSystemExitSystem_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
           
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmproductchild frmproductchild=new frmproductchild();
            //// Set the Parent Form of the Child window.
            //frmproductchild.MdiParent = this;
            //// Display the new form.
            //frmproductchild.Show();
        }

        private void mnuRegistration_Click(object sender, EventArgs e)
        {
            frmNewUser frmpnewuserchild=new frmNewUser();
            // Set the Parent Form of the Child window.
            frmpnewuserchild.MdiParent = this;
            // Display the new form.
            frmpnewuserchild.Show();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmTransaction frmTransactionchild=new frmTransaction();
            // Set the Parent Form of the Child window.
            frmTransactionchild.MdiParent = this;
            // Display the new form.
            frmTransactionchild.Show();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkout frmCheckoutchild=new Checkout();
            // Set the Parent Form of the Child window.
            frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmCheckoutchild.Show();
        }
    }
}
