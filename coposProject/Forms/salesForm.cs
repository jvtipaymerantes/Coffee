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
        public static string prType;

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

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            //Coffee
            pictureBox1.BackColor = Color.FromArgb(229, 192, 132);
            label7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BorderColor = Color.FromArgb(229, 192, 132);

            //  Milk
            pictureBox12.BackColor = Color.FromArgb(186, 155, 105);
            label3.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape3.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape3.BorderColor = Color.FromArgb(186, 155, 105);

            //Sugar
            pictureBox13.BackColor = Color.FromArgb(229, 192, 132);
            label5.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BorderColor = Color.FromArgb(229, 192, 132);

            //Tea
            pictureBox14.BackColor = Color.FromArgb(229, 192, 132);
            label6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BorderColor = Color.FromArgb(229, 192, 132);

            //Syrup
            pictureBox15.BackColor = Color.FromArgb(229, 192, 132);
            label8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BorderColor = Color.FromArgb(229, 192, 132);

            //Other
            label9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BorderColor = Color.FromArgb(229, 192, 132);
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            //Coffee
            pictureBox1.BackColor = Color.FromArgb(229, 192, 132);
            label7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BorderColor = Color.FromArgb(229, 192, 132);

            //Milk
            pictureBox12.BackColor = Color.FromArgb(229, 192, 132);
            label3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BorderColor = Color.FromArgb(229, 192, 132);

            //  Sugar
            pictureBox13.BackColor = Color.FromArgb(186, 155, 105);
            label5.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape6.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape6.BorderColor = Color.FromArgb(186, 155, 105);

            //Tea
            pictureBox14.BackColor = Color.FromArgb(229, 192, 132);
            label6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BorderColor = Color.FromArgb(229, 192, 132);

            //Syrup
            pictureBox15.BackColor = Color.FromArgb(229, 192, 132);
            label8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BorderColor = Color.FromArgb(229, 192, 132);

            //Other
            label9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BorderColor = Color.FromArgb(229, 192, 132);
        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            //Coffee
            pictureBox1.BackColor = Color.FromArgb(229, 192, 132);
            label7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BorderColor = Color.FromArgb(229, 192, 132);

            //Milk
            pictureBox12.BackColor = Color.FromArgb(229, 192, 132);
            label3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BorderColor = Color.FromArgb(229, 192, 132);

            //Sugar
            pictureBox13.BackColor = Color.FromArgb(229, 192, 132);
            label5.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BorderColor = Color.FromArgb(229, 192, 132);

            //  Tea
            pictureBox14.BackColor = Color.FromArgb(186, 155, 105);
            label6.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape7.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape7.BorderColor = Color.FromArgb(186, 155, 105);

            //Syrup
            pictureBox15.BackColor = Color.FromArgb(229, 192, 132);
            label8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BorderColor = Color.FromArgb(229, 192, 132);

            //Other
            label9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BorderColor = Color.FromArgb(229, 192, 132);
        }

        private void rectangleShape8_Click(object sender, EventArgs e)
        {
            //Coffee
            pictureBox1.BackColor = Color.FromArgb(229, 192, 132);
            label7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BorderColor = Color.FromArgb(229, 192, 132);

            //Milk
            pictureBox12.BackColor = Color.FromArgb(229, 192, 132);
            label3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BorderColor = Color.FromArgb(229, 192, 132);

            //Sugar
            pictureBox13.BackColor = Color.FromArgb(229, 192, 132);
            label5.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BorderColor = Color.FromArgb(229, 192, 132);

            //Tea
            pictureBox14.BackColor = Color.FromArgb(229, 192, 132);
            label6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BorderColor = Color.FromArgb(229, 192, 132);

            //  Syrup
            pictureBox15.BackColor = Color.FromArgb(186, 155, 105);
            label8.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape8.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape8.BorderColor = Color.FromArgb(186, 155, 105);

            //Other
            label9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BorderColor = Color.FromArgb(229, 192, 132);
        }

        private void rectangleShape9_Click(object sender, EventArgs e)
        {
            //Coffee
            pictureBox1.BackColor = Color.FromArgb(229, 192, 132);
            label7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape4.BorderColor = Color.FromArgb(229, 192, 132);

            //Milk
            pictureBox12.BackColor = Color.FromArgb(229, 192, 132);
            label3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BorderColor = Color.FromArgb(229, 192, 132);

            //Sugar
            pictureBox13.BackColor = Color.FromArgb(229, 192, 132);
            label5.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BorderColor = Color.FromArgb(229, 192, 132);

            //Tea
            pictureBox14.BackColor = Color.FromArgb(229, 192, 132);
            label6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BorderColor = Color.FromArgb(229, 192, 132);

            //Syrup
            pictureBox15.BackColor = Color.FromArgb(229, 192, 132);
            label8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BorderColor = Color.FromArgb(229, 192, 132);

            //  Other
            label9.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape9.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape9.BorderColor = Color.FromArgb(186, 155, 105);
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            //  Coffee
            pictureBox1.BackColor = Color.FromArgb(186, 155, 105);
            label7.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape4.BackColor = Color.FromArgb(186, 155, 105);
            rectangleShape4.BorderColor = Color.FromArgb(186, 155, 105);

            //Milk
            pictureBox12.BackColor = Color.FromArgb(229, 192, 132);
            label3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape3.BorderColor = Color.FromArgb(229, 192, 132);

            //Sugar
            pictureBox13.BackColor = Color.FromArgb(229, 192, 132);
            label5.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape6.BorderColor = Color.FromArgb(229, 192, 132);

            //Tea
            pictureBox14.BackColor = Color.FromArgb(229, 192, 132);
            label6.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape7.BorderColor = Color.FromArgb(229, 192, 132);

            //Syrup
            pictureBox15.BackColor = Color.FromArgb(229, 192, 132);
            label8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape8.BorderColor = Color.FromArgb(229, 192, 132);

            //Other
            label9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BackColor = Color.FromArgb(229, 192, 132);
            rectangleShape9.BorderColor = Color.FromArgb(229, 192, 132);
        }

        private void salesForm_Load(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select productCode, productName, productType from tblPurchaseReceipt";
            cmd.Connection = con;
            string query = "select * from tblStocks";
            cmd.CommandText = query;
            OleDbDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                prImage = myReader["productImage"].ToString();

                ucSales uc = new ucSales();
                flowLayoutPanel1.Controls.Add(uc);
            }

            con.Close(); 
        }


    }
}
