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
    public partial class forgotpasswordForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public static string q1;
        public static string q2;

        public forgotpasswordForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void forgotpasswordForm_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                con.Open();

                OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string query = "select * from registration where employeeID ='" + txtboxusern.Text + "' or employeeUsername ='" + txtboxusern.Text + "' ";
                cmd.CommandText = query;
                OleDbDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    q1 = myReader["question1"].ToString();
                    q2 = myReader["question2"].ToString();

                }
                
                panel1.Visible = true;
                textBox1.Text = q1;
                textBox2.Text = q2;

                con.Close();
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }


    }
}
