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
    public partial class frmTransaction : Form
    {
        DBHandler repo = new DBHandler();
        public frmTransaction()
        {
            InitializeComponent();
            DisplayData();

        }



        private void DisplayData(DateTime adddate)
        {

            dataGridViewTransactionLog.Rows.Clear();

            DataTable list = repo.GetTransactionLog(adddate);


            foreach (DataRow dr in list.Rows) 
            {
                string[] listda={ dr["BillNo"].ToString(),dr["CustomerName"].ToString(),dr["MobileNumber"].ToString(),dr["Total"].ToString(),dr["AddDate"].ToString()};
                dataGridViewTransactionLog.Rows.Add(listda);


            }

        }

        private void DisplayData()
        {

            dataGridViewTransactionLog.Rows.Clear();

            DataTable list = repo.GetTransactionLog();


            foreach (DataRow dr in list.Rows)
            {
                string[] listda={ dr["BillNo"].ToString(),dr["CustomerName"].ToString(),dr["MobileNumber"].ToString(),dr["Total"].ToString(),dr["AddDate"].ToString()};
                dataGridViewTransactionLog.Rows.Add(listda);


            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DateTime theDate = dateTimeTransactionLog.Value;
            DisplayData(theDate);


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
