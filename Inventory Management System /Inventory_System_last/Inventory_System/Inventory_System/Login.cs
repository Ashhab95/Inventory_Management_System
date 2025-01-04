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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text != "" && txtuserName.Text!="")
            {
                SecUser user=new SecUser();
                DBHandler repo = new DBHandler();

                user.Password = txtpassword.Text;
                user.Username = txtuserName.Text;
                if(repo.LogIn(user))
                {
                  // Main mainform=new Main();
                    MainMenu mainform=new MainMenu();

                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter correct user and password");
                }


            }
            else
            {
                MessageBox.Show("Please enter user and password");
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            frmNewUser frmNewUserchild = new frmNewUser();
            // Set the Parent Form of the Child window.
            //frmCheckoutchild.MdiParent = this;
            // Display the new form.
            frmNewUserchild.Show();
        }
        //private void txtpassword_TextChanged(object sender, EventArgs e)
        //{
           
       // }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {
            if (txtpassword.Text != "")
            {
                txtpassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
