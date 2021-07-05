using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace coposProject
{
    public partial class historyForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public historyForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void historyForm_Load(object sender, EventArgs e)
        {
            string id = null;
            string name = null; ;
            string code = null;
            string product = null; ;
            
            textBox1.Text = ucReceiptPo.currentOrderForm.TextBox1Value;

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select productCode, productName, productType from tblPurchaseReceipt";
            cmd.Connection = con;
            string query = "select tblPurchaseTransaction.referenceID, tblPurchaseTransaction.employee, tblPurchaseReceipt.productCode, tblPurchaseReceipt.productName from tblPurchaseTransaction inner join tblPurchaseReceipt ";
            query += "on tblPurchaseTransaction.referenceID = tblPurchaseReceipt.referenceNo where tblPurchaseTransaction.referenceID = '"+ textBox1.Text +"' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                id = myReader["referenceID"].ToString();
                name = myReader["employee"].ToString();
                code = myReader["productCode"].ToString();
                product = myReader["productName"].ToString();

            }

            con.Close();

            receipt();

        }

        public void receipt()
        {

            txtResult.Clear();
            txtResult.Text += "***************************************\n";
            txtResult.Text += "**       CoPos Coffee Shop            **\n";
            txtResult.Text += "**       Congressional Road Caloocan City            **\n";
            txtResult.Text += "***************************************\n";
            txtResult.Text += "***************************************\n";
            txtResult.Text += "**                Receipt                  **\n";
            txtResult.Text += "***************************************\n";
            

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            string query = "select tblPurchaseTransaction.purchaseDate, tblPurchaseReceipt.productName, tblPurchaseReceipt.productQty, tblPurchaseReceipt.productCostPerItem from tblPurchaseTransaction inner join tblPurchaseReceipt ";
            query += "on tblPurchaseTransaction.referenceID = tblPurchaseReceipt.referenceNo where tblPurchaseTransaction.referenceID = '" + textBox1.Text + "' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            myReader.Read();
            txtResult.Text += "Date: " + myReader["purchaseDate"].ToString() + "\n";
            txtResult.Text += "***************************************\n";

            while (myReader.Read())
            {

                txtResult.Text += "Item: " + myReader["productName"].ToString() +" \n";
                txtResult.Text += "Qty: " + myReader["productQty"].ToString() + " \n";
                txtResult.Text += "Price: " + myReader["productCostPerItem"].ToString() + " \n";

                //id = myReader["referenceID"].ToString();
                //name = myReader["employee"].ToString();
                //code = myReader["productCode"].ToString();
                //product = myReader["productName"].ToString();

                //MessageBox.Show(id + " " + name + " " + code + " " + product);

            }

            con.Close();


        }

    }// End of Class
}
