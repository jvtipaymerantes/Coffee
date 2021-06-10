using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using coposProject.userControl;
using System.IO;

namespace coposProject
{
    public partial class salesPaymentFormEmployee : Form
    {
        public static float change;
        private OleDbConnection con = new OleDbConnection();

        
        public salesPaymentFormEmployee()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salesPaymentFormEmployee_Load(object sender, EventArgs e)
        {

            textBox4.Text = salesFormEmployee.overAll.ToString();

            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Select Count(*) from tblPurchaseTransaction where type = 'Sales' ";
            command.ExecuteNonQuery();
            int transNum = (int)command.ExecuteScalar() + 1;
            con.Close();

            if (transNum == 0)
            {
                transNum = 1;
            }

            StringBuilder rf = new StringBuilder();
            rf.Append("SO" + DateTime.Now.ToString("yyyyMMdd"));
            if(transNum <= 9){
                rf.Append("000" + transNum);
            }
            else if (transNum >= 10 && transNum <= 99)
            {
                rf.Append("00" + transNum);
            }
            else if (transNum >= 100 && transNum <= 999)
            {
                rf.Append("0" + transNum);
            }
            else
            {
                rf.Append(transNum);
            }

            textBox1.Text = rf.ToString();


        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox2.Text) > salesFormEmployee.overAll)
            {

                change = float.Parse(textBox2.Text) - salesFormEmployee.overAll;
                panel3.Visible = false;
                panel2.Visible = true;
                textBox6.Text = change.ToString();
                panel4.Visible = true;
                textBox7.Visible = false;
                textBox2.BorderStyle = BorderStyle.None;

            }
            else
            {
                change = salesFormEmployee.overAll - float.Parse(textBox2.Text);
                textBox7.Text = "Invalid Amount of Cash you are " + change +" less.";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            addItems();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            addItems();
        }

        public void addItems()
        {
            string itemQty = null;
            //Add Items to database
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            foreach (ucSalesReceiptEmployee uc in salesFormEmployee.hereForm.flowLayoutPanel2.Controls)
            {
                command.CommandText = " INSERT INTO tblPurchaseReceipt(referenceNo, productCode, productName, productDescription, productCostPerItem, productQty, type) values('" + textBox1.Text + "', '" + uc.code.ToString() + "', '" + uc.name.ToString() + "', '" + uc.des.ToString() + "', '" + uc.sPrice.ToString() + "', '" + uc.qtyy.ToString() + "', 'Sales') ";
                command.ExecuteNonQuery();

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string query = "select * from tblStocks where productCode = '" + uc.code + "'  ";
                cmd.CommandText = query;
                OleDbDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    itemQty = myReader["productQty"].ToString();
                }

                int quantity = int.Parse(itemQty);
                quantity -= int.Parse(uc.qtyy);

                command.CommandText = " UPDATE tblStocks SET [productQty]='" + quantity.ToString() + "' WHERE productCode =  '" + uc.code.ToString() + "' ";
                command.ExecuteNonQuery();
                
            }

            command.CommandText = " INSERT INTO tblPurchaseTransaction(referenceID, employee, total, tax, cashAmount, change, purchaseDate, type) values('" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "', '" + DateTime.Now.ToString("MM" + "/" + "dd" + "/" + "yyyy" + "PO") + "', 'Sales') ";
            command.ExecuteNonQuery();

            con.Close();
            this.Close();
            //shadowBg.currentShadow.Close();

            salesFormEmployee.hereForm.flowLayoutPanel2.Controls.Clear();
             

            MessageBox.Show("Data Saved! ");

        }




    }
}
