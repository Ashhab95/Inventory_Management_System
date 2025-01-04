using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmproduct : Form

    {

        DBHandler repo = new DBHandler(); // method call to add ,save,update and delete and display the product
        public frmproduct()
        {
            InitializeComponent();
            gridLayout();
            DisplayData();

            btnsave.Enabled = false;
        }
        
        private void gridLayout()
        {
            this.datagrdProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
          
            this.datagrdProduct.Columns[0].Width = 100;
            this.datagrdProduct.Columns[1].Width = 100;
            this.datagrdProduct.Columns[2].Width = 100;
            this.datagrdProduct.Columns[3].Width = 100;
            this.datagrdProduct.DefaultCellStyle.Font = new Font("Tahoma", 9);

        }
        private void btnadd_Click(object sender, EventArgs e) // add the product
        {
            ProductObject prod = new ProductObject();

         
            if(checkproduct())
            {
                prod.ProductCatagory = txtcat.Text;
                prod.ProductName = txtprod.Text;
                prod.ProductPrice = float.Parse(txtprice.Text); // if show the price the data type will be float
                prod.ProductQuantity = int.Parse(txtquantity.Text);


                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(datagrdProduct);
            
                newRow.Cells[0].Value = prod.ProductCatagory;
                newRow.Cells[1].Value = prod.ProductName;
                newRow.Cells[2].Value = prod.ProductQuantity;
                newRow.Cells[3].Value = prod.ProductPrice;

                datagrdProduct.Rows.Add(newRow);

            }


            btnsave.Enabled = true;


            if (repo.AddProduct(prod))
            {
                MessageBox.Show("Added successfully");
                DisplayData();
                textClear();
            }
            else
            {
                MessageBox.Show("Not successfully added");
            }


        }

        private void btnsave_Click(object sender, EventArgs e) // after adding all the product click on the save button
        {
            List<ProductObject> productlist=new List<ProductObject>();

            ProductObject obj=null;
            int countData=0;

            for (int rows = 0; rows < datagrdProduct.Rows.Count; rows++)
            {
                obj = new ProductObject();
             
                try
                {
                    if (datagrdProduct.Rows[rows].Cells[0].Value !=null)
                    {
                        obj.ProductCatagory = datagrdProduct.Rows[rows].Cells[0].Value.ToString();
                        obj.ProductName = datagrdProduct.Rows[rows].Cells[1].Value.ToString();
                        obj.ProductQuantity = int.Parse(datagrdProduct.Rows[rows].Cells[2].Value.ToString());
                        obj.ProductPrice = float.Parse(datagrdProduct.Rows[rows].Cells[3].Value.ToString());

                        if (repo.AddProduct(obj))
                        {
                            countData++;
                        }
                    }
                    
                }
                catch { }

            }

                MessageBox.Show("Total : " + countData.ToString() + "  Succesfully Saved" );

            btnsave.Enabled = false;

        }

        private void btndelete_Click(object sender, EventArgs e) // select the item and delete it 
        {
            ProductObject prodObj = new ProductObject();
            prodObj.ProductCatagory = txtcat.Text;
            prodObj.ProductPrice  = float.Parse(txtprice.Text) ;
            prodObj.ProductName = txtprod.Text;
            prodObj.ProductQuantity = int.Parse(txtquantity.Text);



            if (repo.deleteProduct(prodObj)) 
            {
                MessageBox.Show("Deleted successfully");
                DisplayData();
                textClear();
            }
            else
            {
                MessageBox.Show("Not successfully deleted");
            }
        }

        private void DisplayData() // it displays the product on the table
        {

            datagrdProduct.Rows.Clear();

            DataTable list = repo.GetProductDetails();


            foreach (DataRow dr in list.Rows)
            {
                string[] listda = { dr["Category"].ToString(), dr["Name"].ToString(), dr["Quantity"].ToString(), dr["Price"].ToString() };
                datagrdProduct.Rows.Add(listda);


            }

        }

        private bool checkproduct() 
        {
            if (txtcat.Text == "")
            {
                MessageBox.Show("Please Insert the category");
                return false;
            }
          

            if (txtprod.Text == "")
            {
                MessageBox.Show("Please Insert the Product Name ");
            }
        

            if (txtprice.Text == "")
            {
                MessageBox.Show("Please Insert the  price");
                return false;
            }
         

            if (txtquantity.Text == "")
            {
                MessageBox.Show("Please Insert the Quantity");
                return false;
            }
          

            return true;
        }

        private void datagrdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string test = datagrdProduct.CurrentRow.Cells[0].Value.ToString();
            string test1 = datagrdProduct.CurrentRow.Cells[1].Value.ToString();
            string test2 = datagrdProduct.CurrentRow.Cells[2].Value.ToString();
            string test3 = datagrdProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void datagrdProduct_CellClick(object sender, DataGridViewCellEventArgs e) // to select the product from the cell 
        {
            txtcat.Text = datagrdProduct.CurrentRow.Cells[0].Value.ToString();
            txtprod.Text = datagrdProduct.CurrentRow.Cells[1].Value.ToString();
            txtquantity.Text = datagrdProduct.CurrentRow.Cells[2].Value.ToString();
            txtprice.Text = datagrdProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e) // if you want to update the product then select the item from the product list the update it from the txt box
        {
            ProductObject prod = new ProductObject();
            if (checkproduct())
            {
                prod.ProductCatagory = txtcat.Text;
                prod.ProductName = txtprod.Text;
                prod.ProductPrice = float.Parse(txtprice.Text);
                prod.ProductQuantity = int.Parse(txtquantity.Text);


                if(repo.UpdateProductDetails(prod))
                {
                    MessageBox.Show(prod.ProductName + " Update Sucessful");
                    DisplayData();
                    textClear();

                }

            }
            
           

        }

        private void textClear() // to clear the text from the textbox
        {
            txtcat.Clear();
            txtprice.Clear();
            txtprod.Clear();
            txtquantity.Clear();
        }

        private void btnback_Click(object sender, EventArgs e) // to go back to the main menu
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }

        private void txtcat_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtcat.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Please enter only Character.");
                txtcat.Text = txtcat.Text.Remove(txtcat.Text.Length - 1);
            }
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtprod.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Please enter only Character.");
                txtprod.Text = txtprod.Text.Remove(txtcat.Text.Length - 1);
            }
        }
    }
}
