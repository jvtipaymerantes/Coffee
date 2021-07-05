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
    public partial class salesFormEmployee : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string prImage;
        public static string prCode;
        public static string prName;
        public static string prCost;

        public static float overAll;

        public static salesFormEmployee hereForm = null;

        public salesFormEmployee()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new mainForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new inventoryFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void salesFormEmployee_Load(object sender, EventArgs e)
        {
            hereForm = this;

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            string query = "select * from tblStocks where productQty > '0' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                prImage = myReader["productImage"].ToString();
                prCode = myReader["productCode"].ToString();
                prName = myReader["productName"].ToString();
                prCost = myReader["productSellingPrice"].ToString();

                ucSalesEmployee uc = new ucSalesEmployee();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            ucSalesReceiptEmployee a = new ucSalesReceiptEmployee();
            flowLayoutPanel2.Controls.Add(a);
        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {

            overAll = 0;

            con.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            foreach (ucSalesReceiptEmployee uc in flowLayoutPanel2.Controls)
            {
                overAll += float.Parse(uc.itemPrice);
            }

            con.Close();

            salesPaymentFormEmployee a = new salesPaymentFormEmployee();
            a.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new login();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label15.Text = DateTime.Now.ToLongDateString();

            StringBuilder sbTotal = new StringBuilder();
            sbTotal.Append("PAYOUT(");
            sbTotal.Append(overAll);
            sbTotal.Append(")");
            label10.Text = sbTotal.ToString();

            //foreach (ucSalesReceipt uc in flowLayoutPanel2.Controls)
            //{
            //    overAll = overAll + float.Parse(uc.itemPrice);
            //}

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            string query = "select * from tblStocks where productName LIKE '%"+ textBox1.Text +"%' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                prImage = myReader["productImage"].ToString();
                prCode = myReader["productCode"].ToString();
                prName = myReader["productName"].ToString();
                prCost = myReader["productCostPerItem"].ToString();

                ucSalesEmployee uc = new ucSalesEmployee();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            if (comboBox1.Text.Equals("All"))
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string query = "select * from tblStocks";
                cmd.CommandText = query;
                OleDbDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    prImage = myReader["productImage"].ToString();
                    prCode = myReader["productCode"].ToString();
                    prName = myReader["productName"].ToString();
                    prCost = myReader["productCostPerItem"].ToString();

                    ucSalesEmployee uc = new ucSalesEmployee();
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();

                

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string query = "select * from tblStocks where productType LIKE '%" + comboBox1.Text + "%' ";
                cmd.CommandText = query;
                OleDbDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    prImage = myReader["productImage"].ToString();
                    prCode = myReader["productCode"].ToString();
                    prName = myReader["productName"].ToString();
                    prCost = myReader["productCostPerItem"].ToString();

                    ucSalesEmployee uc = new ucSalesEmployee();
                    flowLayoutPanel1.Controls.Add(uc);
                }

                
            }// End of If

            con.Close();
        }

        private void flowLayoutPanel2_ControlAdded(object sender, ControlEventArgs e)
        {
            overAll += float.Parse(ucSalesReceiptEmployee.a.itemPrice);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
