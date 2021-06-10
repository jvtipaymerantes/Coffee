using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace coposProject
{
    public partial class ucSalesEmployee : UserControl
    {

        private OleDbConnection con = new OleDbConnection();

        public static string productCodeSales;

        public ucSalesEmployee()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void ucSalesEmployee_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = salesFormEmployee.prImage;
            textBox1.Text = salesFormEmployee.prName;
            textBox2.Text = salesFormEmployee.prCost;
            label3.Text = salesFormEmployee.prCode;
        }

        

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            productCodeSales = label3.Text;

            ucSalesReceiptEmployee a = new ucSalesReceiptEmployee();
            salesFormEmployee.hereForm.flowLayoutPanel2.Controls.Add(a);

        }



    }
}
