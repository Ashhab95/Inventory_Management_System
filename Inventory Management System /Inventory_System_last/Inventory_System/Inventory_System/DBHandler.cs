using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{

    public class DBHandler // class for db 
    {
        #region Decliaration
        string conString = @"Data Source=KAZI-PC\MSSQLSERVER2;Initial Catalog=InventorySystem;User ID=sa;Password=958643";

        public string ConString
        {
            set { conString = value; }
        }
        private SqlConnection conn = new SqlConnection();
        #endregion
        public DBHandler()
        {
            conn.ConnectionString = conString;
        }
        public bool ExecuteCommand(string QueryString)
        {
            try
            {
                conn.ConnectionString = conString;
                conn.Open();
                SqlCommand sqlCom = new SqlCommand(QueryString, conn);
                if (sqlCom.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;

            }
            catch (Exception errorException)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw errorException;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool AddProduct(ProductObject prodparameter)
        { 

            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("spAddProduct", con))
                    {
                        
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@pCategory", SqlDbType.NVarChar,50).Value = prodparameter.ProductCatagory;
                        cmd.Parameters.Add("@pName", SqlDbType.NVarChar, 50).Value = prodparameter.ProductName;
                        cmd.Parameters.Add("@pPrice", SqlDbType.Float).Value = prodparameter.ProductPrice;
                        cmd.Parameters.Add("@pQuantity", SqlDbType.Int).Value = prodparameter.ProductQuantity;
             

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }

        
           
        }// push the data into the db 

        internal bool AddProduct(object prodObj)
        {
            throw new NotImplementedException();
        }
       // and pull the data

        public bool AddTransactionLog(ProductObject prodparameter)
        {

            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_AddTransactionLog", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@pBillNo", SqlDbType.NVarChar, 50).Value = prodparameter.BillNo;
                        cmd.Parameters.Add("@pCustomerName", SqlDbType.NVarChar, 50).Value = prodparameter.BillerName;
                        cmd.Parameters.Add("@pItems", SqlDbType.NVarChar, 50).Value = prodparameter.Item;
                        cmd.Parameters.Add("@pMobileNumber", SqlDbType.NVarChar, 50).Value = prodparameter.MobileNo;
                        cmd.Parameters.Add("@pTotal", SqlDbType.Float).Value = prodparameter.Totalprice;


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }



        } // after checking out all the bill will be stored to the transaction table into the db 

        public bool UserCheck(string UserName, string UserPassword, int strUserType)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("UserAuthentication", con))
                    {
                        int result = 0;
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@User_Name", SqlDbType.VarChar, 15).Value = UserName;
                        cmd.Parameters.Add("@User_Password", SqlDbType.VarChar, 15).Value = UserPassword;
                        cmd.Parameters.Add("@User_TypeID", SqlDbType.Int).Value = strUserType;
                        cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        result = (int)cmd.Parameters["@result"].Value;
                        con.Close();

                        if (result == 1)
                            return true;
                        else return false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }  // for the validations of user id from db

        public bool LogIn(SecUser parameter)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                byte[] byteArray = new byte[1024];
                using (SqlCommand cmd = new SqlCommand("spLogin", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pUserID", SqlDbType.NVarChar, 50).Value = parameter.Username;// parameter.Name;
                    cmd.Parameters.Add("@pPassword", SqlDbType.NVarChar, 50).Value = parameter.Password;//parameter.UserID;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["UserName"] != null)
                        {
                            if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                                return true;

                        }
                    }


                    return false;
                }
            }


        } // get user from db 

        public DataTable GetProductDetails()
        {

            List<String> catList = new List<string>();
            //spGetData
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Product", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

          
            conn.Close();
          

            return dt;
        } 

        public DataTable deleteProduct()
        {
            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Product)", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception errorException)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw errorException;
            }
            finally
            {
                conn.Close();
            }
        }  // deete items from the db table

        public DataTable Getcatogry()
        {
            List<String> catList = new List<string>();
            //spGetData
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select DISTINCT Category from Product", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);



            return dt;





        } // get category from db

        public DataTable GetProductCategoryList(string categoryName)
        {
           

            using (SqlConnection con = new SqlConnection(conString))
            {
                
                using (SqlCommand cmd = new SqlCommand("spGetCategoryList", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pCategory", SqlDbType.NVarChar, 50).Value = categoryName;// parameter.Name;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    if (dr["UserName"] != null)
                    //    {
                    //        if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                    //            return true;

                    //    }
                    //}


                    return dt;
                }
            }

          
        } // get product category list for the dropdown menu

        public DataTable GetProductItemList(string ItemName)
        {




            using (SqlConnection con = new SqlConnection(conString))
            {



                using (SqlCommand cmd = new SqlCommand("spGetItemList", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.Add("@pItem", SqlDbType.NVarChar, 50).Value = ItemName;// parameter.Name;



                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);




                    //foreach (DataRow dr in dt.Rows)
                    //{
                    // if (dr["UserName"] != null)
                    // {
                    // if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                    // return true;



                    // }
                    //}




                    return dt;
                }
            }




        } // get product item list for the search

        public bool UpdateProductDetails(ProductObject prodparameter)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateProduct", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@pCategory", SqlDbType.NVarChar, 50).Value = prodparameter.ProductCatagory;
                        cmd.Parameters.Add("@pName", SqlDbType.NVarChar, 50).Value = prodparameter.ProductName;
                        cmd.Parameters.Add("@pPrice", SqlDbType.Float).Value = prodparameter.ProductPrice;
                        cmd.Parameters.Add("@pQuantity", SqlDbType.Int).Value = prodparameter.ProductQuantity;


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }
        } // update details in db and table 

        public bool deleteProduct(ProductObject prodOBJ)
        {
            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_deleteProduct", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

              
                        cmd.Parameters.Add("@pProductName", SqlDbType.NVarChar, 50).Value = prodOBJ.ProductName;


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }
        } //  delete product from the db table

        public bool ChangePassword (SecUser ChangePass)
        {
            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_ChangePassword", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add("@pUserName", SqlDbType.NVarChar, 50).Value = ChangePass.Username;
                        cmd.Parameters.Add("@pOldPassword", SqlDbType.NVarChar, 50).Value = ChangePass.OldPassword;
                        cmd.Parameters.Add("@pNewPassword", SqlDbType.NVarChar, 50).Value = ChangePass.NewPassword;


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }
        } // password change matho from db

        public bool CheckExistingPassword(SecUser ChangePass)
        {
            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");



                //conn.Open();
                //query = "spInsertTemplate";



                using (SqlConnection con = new SqlConnection(conString))
                {



                    using (SqlCommand cmd = new SqlCommand("GetPassword", con))
                    {



                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;




                        cmd.Parameters.Add("@pUserName", SqlDbType.NVarChar, 50).Value = ChangePass.Username;
                        cmd.Parameters.Add("@pOldPassword", SqlDbType.NVarChar, 50).Value = ChangePass.OldPassword;



                        //cmd.Parameters.Add("@pNewPassword", SqlDbType.NVarChar, 50).Value = ChangePass.NewPassword;




                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);




                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["UserName"] != null)
                            {
                                if (ChangePass.Username == (string)dr["UserName"] && ChangePass.OldPassword == (string)dr["Password"])
                                    return true;



                            }
                        }




                        return false;
                    }
                }



            }
            catch (Exception errorException)
            {
                return false;
            }
        } // validation of username and password from db
        public bool checkprod (string prodname)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                int result = 0;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("sp_CheckProductAvilability", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
             
                sqlCmd.Parameters.AddWithValue("@pProductName", prodname);
                sqlCmd.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;

                sqlCmd.ExecuteNonQuery();
                result = (int)sqlCmd.Parameters["@Result"].Value;
                sqlCon.Close();

                if (result == 1)
                    return true;
                else
                    return false;

            }
        } // product availability method 

        public bool productCalculation(string prodName)
        {

            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                int result = 0;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("sp_calProduct", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pName", prodName);
                sqlCmd.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;

                sqlCmd.ExecuteNonQuery();
                result = (int)sqlCmd.Parameters["@Result"].Value;
                sqlCon.Close();

                if (result == 1)
                    return true;
                else
                    return false;

            }
        } // stock deduction method 

        #region checkout

        public DataTable GetProductbillList()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("spGetCheckoutTempList", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    if (dr["UserName"] != null)
                    //    {
                    //        if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                    //            return true;

                    //    }
                    //}


                    return dt;
                }
            }


        } // bill list method

        public DataTable GetTransactionLog()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_GetTransactionLog", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    if (dr["UserName"] != null)
                    //    {
                    //        if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                    //            return true;

                    //    }
                    //}


                    return dt;
                }
            }


        } // pull data for the transaction log 
        public DataTable GetTransactionLog(DateTime adddate)
        {


            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_GetTransactionLog_", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@AddDate", SqlDbType.Date).Value = adddate;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    if (dr["UserName"] != null)
                    //    {
                    //        if (parameter.Username == (string)dr["UserName"] && parameter.Password == (string)dr["Password"])
                    //            return true;

                    //    }
                    //}


                    return dt;
                }
            }


        } // searching transaction log by date 
        public bool ClearTempBillTable()
        {
           try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_CleareCheckoutTable", con))
                    {
                       
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        con.Close();

                        return true;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
                
            }
        }  // checkout table clear mathod 
        public bool AddItemBill(string itemName, string itemPrice)
        {

            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";

                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_InsertItemBill", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = itemName;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = float.Parse(itemPrice);
                     


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }



        } // add item for the checkout from db 

        public bool DeleteItemBill(string itemName, string itemPrice)
        {

            try
            {
                //SqlCommand sqlCom = new SqlCommand("select * from dms_DeviceLog where ID = (select MAX(ID) from dms_DeviceLog)");

                //conn.Open();
                //query = "spInsertTemplate";


                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand("sp_DeleteItemBill", con))
                    {

                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = itemName;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = float.Parse(itemPrice);
                        cmd.ExecuteNonQuery();


                        return true;
                    }
                }

            }
            catch (Exception errorException)
            {
                return false;
            }





        } // delete item from the checoutbill from db

        #endregion
    }
}
