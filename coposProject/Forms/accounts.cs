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
    public partial class accounts : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string empId;
        public static string empName;
        public static string empPos;
        public static string empUser;

        public accounts()
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

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new registerForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
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

        private void accounts_Load(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select employeeID, employeeName, employeePosition, employeeUsername from registration";
            cmd.Connection = con;
            string query = "select * from registration";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                empId = myReader["employeeID"].ToString();
                empName = myReader["employeeName"].ToString();
                empPos = myReader["employeePosition"].ToString();
                empUser = myReader["employeeUsername"].ToString();
                ucAcc uc = new ucAcc();
                flowLayoutPanel1.Controls.Add(uc);

            }

            con.Close();
        }

        

    }
}
