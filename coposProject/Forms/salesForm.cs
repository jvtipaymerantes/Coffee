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
    public partial class salesForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string prImage;
        public static string prCode;
        public static string prName;
        public static string prCost;

        public static float overAll;

        public static salesForm hereForm = null;

        public salesForm()
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
            var a = new inventoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new purchaseForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new statisticsForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new accounts();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }



        private void salesForm_Load(object sender, EventArgs e)
        {
            hereForm = this;

            con.Open();

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

                ucSales uc = new ucSales();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close();


        }

        private void label11_Click(object sender, EventArgs e)
        {
            ucSalesReceipt a = new ucSalesReceipt();
            flowLayoutPanel2.Controls.Add(a);
        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {
            
            con.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            foreach (ucSalesReceipt uc in flowLayoutPanel2.Controls)
            {
                overAll += float.Parse(uc.itemPrice);
            }

            MessageBox.Show(overAll.ToString() );

            con.Close();

            salesPaymentForm a = new salesPaymentForm();
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

                ucSales uc = new ucSales();
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

                    ucSales uc = new ucSales();
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

                    ucSales uc = new ucSales();
                    flowLayoutPanel1.Controls.Add(uc);
                }

                
            }// End of If

            con.Close();
        }


    }
}
