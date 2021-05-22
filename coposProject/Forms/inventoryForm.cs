﻿using System;
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
    public partial class inventoryForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string prCode;
        public static string prName;
        public static string prType;

        public inventoryForm()
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
            var a = new orderHistoryForm();
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

        private void inventoryForm_Load(object sender, EventArgs e)
        {
            /*
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select productCode, productName, productType from tblPurchaseReceipt";
            OleDbCommand cmd2 = con.CreateCommand();
            OleDbDataReader a = new OleDbDataReader();
            a = cmd2.ExecuteReader();

            //while( a.Read() ){

                //ucInventory uc = new ucInventory();

                //prCode = a("productCode");

            
            //}




            con.Close(); */

            ucInventory uc = new ucInventory();
            flowLayoutPanel1.Controls.Add(uc);

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            ucInventory uc = new ucInventory();
            flowLayoutPanel1.Controls.Add(uc);
        }




    }
}
