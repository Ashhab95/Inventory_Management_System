using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class frmNewUser : Form
    {
        String connectionString = @"Data Sour=KAZI-PC\MSSQLSERVER2;Initial Catalog=InventorySystem;User ID=sa;Password=Cns#1234;";
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" || txtpassword.Text == "")
                MessageBox.Show("Please fill mandatory");
            else if (txtpassword.Text != txtconfirmPassword.Text)
                MessageBox.Show("password does not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    int result = 0;
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", txtuserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MobileNumber", txtmobileNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AdminPassword", txtadminPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;

                    sqlCmd.ExecuteNonQuery();
                    result = (int)sqlCmd.Parameters["@Result"].Value;
                    sqlCon.Close();

                    if (result == 1)
                        MessageBox.Show("Registration is successfull");
                    else
                        MessageBox.Show("Registration is not successfull");


                    Clear();
                    
                   




                }
            }
            

        }

        void Clear ()
        {
            txtFirstName.Text = txtuserName.Text = txtmobileNumber.Text = txtaddress.Text = txtadminPassword.Text = txtpassword.Text = txtconfirmPassword.Text = "";
        }
    }
}
