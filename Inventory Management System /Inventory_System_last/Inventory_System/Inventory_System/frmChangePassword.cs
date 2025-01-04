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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            HidePassword();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SecUser ChangeUser = new SecUser();

            if (checkpass())
            {
                ChangeUser.Username = txtUserName.Text;
                ChangeUser.OldPassword = txtOldPassword.Text;
                ChangeUser.NewPassword = txtNewPassword.Text;
                ChangeUser.Password = txtConfirmPassword.Text;



                if (ChangeUser.NewPassword == ChangeUser.Password)
                {
                    DBHandler chPass = new DBHandler();

                    if (chPass.CheckExistingPassword(ChangeUser))
                    {
                        if (chPass.ChangePassword(ChangeUser))
                        {
                            MessageBox.Show("Password successfully changed");
                            ClearText();

                        }

                        else
                        {
                            MessageBox.Show("Password Did not Match");

                        }

                    }
                    else
                    {
                        MessageBox.Show("You entered the wrong current password");
                    }
                }
                else
                {
                    MessageBox.Show("Password Did Not Match");
                }
            }
            }
        private void ClearText()
        {
            txtUserName.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

        }

        private void HidePassword()
        {
            txtOldPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private bool checkpass() 
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Insert the Username");
                return false;
            }

            if (txtOldPassword.Text == "")
            {
                MessageBox.Show("Please Insert your old password ");
            }


            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please Insert the new password");
                return false;
            }

            if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please confirm your password");
                return false;
            }

            return true;
        }

    }

}
    
    

