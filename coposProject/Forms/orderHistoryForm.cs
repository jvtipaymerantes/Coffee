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
    public partial class orderHistoryForm : Form
    {

        private OleDbConnection con = new OleDbConnection();
        

        public static string poId;
        public static string poEmployee;
        public static string poTotal;
        public static string poDate;

        public orderHistoryForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new mainForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new inventoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new salesForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new purchaseForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new statisticsForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new accounts();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucReceiptPo uc = new ucReceiptPo();
            flowLayoutPanel1.Controls.Add(uc);
        }

        private void orderHistoryForm_Load(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select productCode, productName, productType from tblPurchaseReceipt";
            cmd.Connection = con;
            string query = "select * from tblPurchaseTransaction";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                
                poId = myReader["referenceID"].ToString();
                poEmployee = myReader["employee"].ToString();
                poTotal = myReader["total"].ToString();
                poDate = myReader["purchaseDate"].ToString();
                ucReceiptPo uc = new ucReceiptPo();
                flowLayoutPanel1.Controls.Add(uc);
                 
            }

            con.Close();

            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new login();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label16.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
