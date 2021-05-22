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
    public partial class login : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public login()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            int i = 0;



            try
            {

                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Please enter username and password");
                }

                cmd = new OleDbCommand("SELECT COUNT(*) FROM registration WHERE employeeID = '" + textBox1.Text + "' OR employeeUsername ='" + textBox1.Text + "' AND employeePassword ='" + textBox2.Text + "'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    i = (int)cmd.ExecuteScalar();
                }
                con.Close();

                if (i > 0)
                {
                    mainForm mn = new mainForm();
                    this.Hide();
                    mn.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void rectangleShape6_MouseHover(object sender, EventArgs e)
        {
            rectangleShape5.Visible = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(99, 72, 50);
        }

        private void rectangleShape6_MouseLeave(object sender, EventArgs e)
        {
            rectangleShape5.Visible = false;
            label3.ForeColor = System.Drawing.Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
