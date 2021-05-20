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

namespace coposProject
{
    public partial class purchasePaymentForm : Form
    {
        public static float change;
        private OleDbConnection con = new OleDbConnection();
        public static purchaseForm a = null;

        public purchasePaymentForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchasePaymentForm_Load(object sender, EventArgs e)
        {
            StringBuilder rf = new StringBuilder();
            rf.Append("PO" + DateTime.Now.ToString("yyyyMMdd"));
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
            
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            MessageBox.Show("Phase 1");
                
            foreach (userControl.purchaseOrderUc uc in a.flowLayoutPanel1.Controls)
            {
                MessageBox.Show(uc.TextBox1Value + " " + uc.TextBox2Value + " " + uc.TextBox3Value + " " + uc.TextBox4Value + " " + uc.TextBox5Value + " " + uc.TextBox6Value + " " + uc.TextBox7Value);
                command.CommandText = " INSERT INTO tblPurchaseReceipt(referenceNo, productCode, productName, productDescription, productCostPerItem, productQty, total, cashAmount, change) values('" + textBox1.Text + "', '" + uc.TextBox1Value.ToString() + "', '" + uc.TextBox2Value.ToString() + "', '" + uc.TextBox3Value.ToString() + "', '" + uc.TextBox6Value.ToString() + "', '" + uc.TextBox8Value.ToString() + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "') ";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved!");
            }

            con.Close();
            this.Close();

        }



    }
}
