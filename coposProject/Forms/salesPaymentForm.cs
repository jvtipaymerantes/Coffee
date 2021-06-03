﻿using System;
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
    public partial class salesPaymentForm : Form
    {
        public static float change;
        private OleDbConnection con = new OleDbConnection();

        
        public salesPaymentForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["shadowBg"].Close();
        }

        private void salesPaymentForm_Load(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Select Count(*) from tblPurchaseTransaction";
            command.ExecuteNonQuery();
            int transNum = (int)command.ExecuteScalar() + 1;
            con.Close();

            if (transNum == 0)
            {
                transNum = 1;
            }

            StringBuilder rf = new StringBuilder();
            rf.Append("PO" + DateTime.Now.ToString("yyyyMMdd"));
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

            purchaseForm a = new purchaseForm();
            textBox5.Text = a.LabelText;

            textBox4.Text = purchaseForm.overallTotal.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox2.Text) > purchaseForm.overallTotal)
            {

                change = float.Parse(textBox2.Text) - purchaseForm.overallTotal;
                panel3.Visible = false;
                panel2.Visible = true;
                textBox6.Text = change.ToString();
                panel4.Visible = true;
                textBox7.Visible = false;
                textBox2.BorderStyle = BorderStyle.None;

            }
            else
            {
                change = purchaseForm.overallTotal - float.Parse(textBox2.Text);
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
            //Add Items to database
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            foreach (userControl.purchaseOrderUc uc in purchaseForm.currentForm.flowLayoutPanel1.Controls)
            {
                command.CommandText = " INSERT INTO tblPurchaseReceipt(referenceNo, productCode, productName, productDescription, productCostPerItem, productQty) values('" + textBox1.Text + "', '" + uc.TextBox1Value.ToString() + "', '" + uc.TextBox2Value.ToString() + "', '" + uc.TextBox3Value.ToString() + "', '" + uc.TextBox6Value.ToString() + "', '" + uc.TextBox8Value.ToString() + "') ";
                command.ExecuteNonQuery();

                // To Create Random Filename
                string fileName = System.Convert.ToString(DateTime.Now.Ticks) + ".jpeg";
                // Destination Folder kung san ilalagay yung Image (bin\Debug\image) + image file name
                string destFolder = Path.Combine("image/", fileName);

                command.CommandText = " INSERT INTO tblStocks(productImage, productCode, productName, productDescription, productType, productUnit, productCostPerItem, productExpDate, productQty) values('" + destFolder + "', '" + uc.TextBox1Value.ToString() + "', '" + uc.TextBox2Value.ToString() + "', '" + uc.TextBox3Value.ToString() + "', '" + uc.TextBox4Value.ToString() + "', '" + uc.TextBox5Value.ToString() + "', '" + uc.TextBox6Value.ToString() + "', '" + uc.TextBox7Value.ToString() + "', '" + uc.TextBox8Value.ToString() + "') ";
                command.ExecuteNonQuery();

                // Copy Image
                File.Copy(uc.imageLoc, destFolder, true);

                MessageBox.Show("Data Saved! " + destFolder.ToString());
            }

            command.CommandText = " INSERT INTO tblPurchaseTransaction(referenceID, employee, total, tax, cashAmount, change, purchaseDate) values('" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "', '" + DateTime.Now.ToString("MMddyyyy") + "') ";
            command.ExecuteNonQuery();

            con.Close();
            this.Close();
            shadowBg.currentShadow.Close();

            purchaseForm.currentForm.flowLayoutPanel1.Controls.Clear();
        }




    }
}