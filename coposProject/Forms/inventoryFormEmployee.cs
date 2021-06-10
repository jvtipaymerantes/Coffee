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
    public partial class inventoryFormEmployee : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string prImage;
        public static string prCode;
        public static string prName;
        public static string prType;

        public inventoryFormEmployee()
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

        private void label7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void inventoryFormEmployee_Load(object sender, EventArgs e)
        {
            
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select productCode, productName, productType from tblPurchaseReceipt";
            cmd.Connection = con;
            string query = "select * from tblStocks";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while(myReader.Read()){

                prImage = myReader["productImage"].ToString();
                prCode = myReader["productCode"].ToString();
                prName = myReader["productName"].ToString();
                prType = myReader["productType"].ToString();

                ucInventoryEmployee uc = new ucInventoryEmployee();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close(); 

        }

        private void label11_Click(object sender, EventArgs e)
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
            label12.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            string query = "select * from tblStocks where productName LIKE '%" + textBox1.Text + "%' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                prImage = myReader["productImage"].ToString();
                prCode = myReader["productCode"].ToString();
                prName = myReader["productName"].ToString();

                ucInventoryEmployee uc = new ucInventoryEmployee();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new salesFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }


    }
}
