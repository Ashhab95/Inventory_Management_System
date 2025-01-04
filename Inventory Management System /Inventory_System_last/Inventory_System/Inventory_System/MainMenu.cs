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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btncheckOut_Click(object sender, EventArgs e)
        {
            Checkout frmCheckoutchild =new Checkout();
            // Set the Parent Form of the Child window.
            //frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmCheckoutchild.Show();

            this.Hide();
        }

        private void btnTransactionLog_Click(object sender, EventArgs e)
        {
            frmTransaction frmTransactionChild = new frmTransaction();
            // Set the Parent Form of the Child window.
            //frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmTransactionChild.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmproduct frmproductchild = new frmproduct();
            // Set the Parent Form of the Child window.
            //frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmproductchild.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePasswordchild = new frmChangePassword();
            // Set the Parent Form of the Child window.
            //frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmChangePasswordchild.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
