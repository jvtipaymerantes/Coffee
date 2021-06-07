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
    public partial class ucSalesReceipt : UserControl
    {

        private OleDbConnection con = new OleDbConnection();

        private int qty = 1;
        public static float itemPerCost;
        public static float origCost;

        public static ucSalesReceipt a = null;

        public ucSalesReceipt()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void ucSalesReceipt_Load(object sender, EventArgs e)
        {

            a = this;
            qty = 1;

            label3.Text = ucSales.productCodeSales;

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            string query = "select * from tblStocks where productCode='"+ label3.Text +"' ";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                textBox1.Text = myReader["productName"].ToString();
                textBox2.Text = myReader["productCostPerItem"].ToString();
            }

            origCost = float.Parse(textBox2.Text);
            itemPerCost = float.Parse(textBox2.Text);

            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            qty++;

            itemPerCost += origCost;

            textBox2.Text = itemPerCost.ToString();
            textBox3.Text = qty.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!(qty == 1))
            {
                qty--;

                itemPerCost -= origCost;

                textBox2.Text = itemPerCost.ToString();
                textBox3.Text = qty.ToString();

            }

        }

        public string itemPrice
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }


    }
}
