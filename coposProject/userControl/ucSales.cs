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
    public partial class ucSales : UserControl
    {

        private OleDbConnection con = new OleDbConnection();

        public static string productCodeSales;

        public ucSales()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void ucSales_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = salesForm.prImage;
            textBox1.Text = salesForm.prName;
            textBox2.Text = salesForm.prCost;
            label3.Text = salesForm.prCode;
        }

        

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            productCodeSales = label3.Text;

            ucSalesReceipt a = new ucSalesReceipt();
            salesForm.hereForm.flowLayoutPanel2.Controls.Add(a);

        }



    }
}
