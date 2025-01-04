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
    public partial class Checkout : Form
    {
        DBHandler repo = new DBHandler();

        ProductObject productObj=null;
        public Checkout()
        {
            InitializeComponent();
            loadCombobox();
            repo.ClearTempBillTable();
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            String billNo =  (DateTime.Now.ToString("MMddyyyyss") + randomNumber.ToString()) ;
            txtbillNo.Text = billNo.Substring(6, billNo.Length-7);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//method for clicking label 

        private void loadCombobox()
        {
            cmbcat.Text = "--Select--";

            DataTable dt = repo.Getcatogry();
            foreach (DataRow row in dt.Rows)
            {
                this.cmbcat.Items.Add(row.ItemArray[0]);
            }
        }//method for calling category list 

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewItem.Rows.Clear();
            string selectList=cmbcat.SelectedItem.ToString();
      

            DataTable list = repo.GetProductCategoryList(cmbcat.SelectedItem.ToString());


            foreach (DataRow dr in list.Rows)
            {
                string[] listda={ dr["Name"].ToString(), dr["Price"].ToString()};
                dataGridViewItem.Rows.Add(listda);
               

            }
          
        }//method for dropdown category 

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//method for showing item on the grid

        private void btnadd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("PRICE");
            foreach (DataGridViewRow row in dataGridViewItem.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chkbox"].Value);
                if (isSelected)
                {
                    if(checkProdArrival(row.Cells[0].Value.ToString()))
                    {
                        if (AddItem(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()))
                            DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("PRODUCT Is not avilable");
                    }


                    
                }
            }

           

          
        }//button for adding to the cart

        private bool checkProdArrival(string prodName)
        {
            return repo.checkprod(prodName);
        }//check for stock 

        private bool AddItem(string itemname , string price)
        {
           
            return repo.AddItemBill(itemname, price);
        }

        private bool DeleteItem(string itemname, string price) // method call of delete action
        {

            return repo.DeleteItemBill(itemname, price);
        }

        private void DisplayData()
        {

            dataGridViewbill.Rows.Clear();

            DataTable list = repo.GetProductbillList();


            foreach (DataRow dr in list.Rows)
            {
                string[] listda={ dr["ITEM"].ToString(), dr["QUANTITY"].ToString(),dr["PRICE"].ToString(),dr["TOTALPRICE"].ToString()};
                dataGridViewbill.Rows.Add(listda);


            }

        }//method for displaying data on the table

        private void btnSave_Click(object sender, EventArgs e)
        {
            productObj = new ProductObject();

            if (checkproduct())
            {
                productObj.BillNo = txtbillNo.Text;
                productObj.BillerName = txtname.Text;
                productObj.MobileNo = txtmobile.Text;
            }
            else
            {
                return;
            }
           


            int countData=0;

            for (int rows = 0; rows < dataGridViewbill.Rows.Count; rows++)
            {
               

                try
                {
                    if (dataGridViewbill.Rows[rows].Cells[0].Value != null)
                    {
                        productObj.Item = dataGridViewbill.Rows[rows].Cells[0].Value.ToString();
                        productObj.ProductQuantity = int.Parse( dataGridViewbill.Rows[rows].Cells[1].Value.ToString());
                        productObj.ProductPrice = float.Parse(dataGridViewbill.Rows[rows].Cells[2].Value.ToString());
                        productObj.Totalprice = float.Parse(dataGridViewbill.Rows[rows].Cells[3].Value.ToString());

                        if (repo.AddTransactionLog(productObj))
                        {
                            repo.productCalculation(productObj.Item);
                            countData++;
                        }
                    }

                }
                catch { }
                
            }
            MessageBox.Show("Data Save successful count :" + countData.ToString());

            this.Hide();
            frmTransaction frmTransactionChild = new frmTransaction();
            frmTransactionChild.Show();
        }//method for save button


        private bool checkproduct()
        {
           
            if (txtname.Text == "")
            {
                MessageBox.Show("Please Insert the Customer Name ");
            }

            if (txtmobile.Text == "")
            {
                MessageBox.Show("Please Insert the  Mobile No ");
                return false;
            }

          

            return true;
        }//validation for customer name

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();


        }//button for returning back to main menu 

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmobile.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtmobile.Text = txtmobile.Text.Remove(txtmobile.Text.Length - 1);
            }
        }//validation for mobile numbers

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String SearchItems = txtSearch.Text;



            dataGridViewItem.Rows.Clear();




            DataTable list = repo.GetProductItemList(SearchItems);




            foreach (DataRow dr in list.Rows)
            {
                string[] listda = { dr["Name"].ToString(), dr["Price"].ToString() };
                dataGridViewItem.Rows.Add(listda);




            }
        }//method for search button 

        private void btndelete_Click(object sender, EventArgs e)
        
            {
                ReadGride();
            } // delete action method



            // New Add
            private void dataGridViewbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                foreach (DataGridViewRow row in dataGridViewbill.SelectedRows)
                {
                    String deleteItem1 = row.Cells[0].Value.ToString();
                    String deleteItem2 = row.Cells[1].Value.ToString();
                }



            }



            private void ReadGride()
            {
                foreach (DataGridViewRow row in dataGridViewbill.SelectedRows)
                {
                    String productName = row.Cells[0].Value.ToString();
                    String productPrice = row.Cells[2].Value.ToString();



                    if (DeleteItem(productName, productPrice))
                        DisplayData();
                }
            }
        }
    
}
