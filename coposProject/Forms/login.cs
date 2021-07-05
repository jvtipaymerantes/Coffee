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

        private void lgn()
        {
            OleDbCommand cmd = new OleDbCommand();
            int i = 0;

            if (textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                rectangleShape3.BorderColor = Color.FromArgb(205, 97, 85);
                rectangleShape4.BorderColor = Color.FromArgb(205, 97, 85);
            }
            else
            {
                try
                {


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
                        panel6.Visible = true;
                        rectangleShape3.BorderColor = Color.FromArgb(205, 97, 85);
                        rectangleShape4.BorderColor = Color.FromArgb(205, 97, 85);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            lgn();
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label5.Visible = false;
                textBox1.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label5.Visible = true;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label6.Visible = false;
                textBox2.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label6.Visible = true;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox6.Location = new Point(290, 13);
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            pictureBox6.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lgn();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var forgotpasswordForm = new forgotpasswordForm();
            forgotpasswordForm.Closed += (s, args) => this.Close();
            forgotpasswordForm.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            /*
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Select Count(*) from registration";
            command.ExecuteNonQuery();
            int transNum = (int)command.ExecuteScalar();
            con.Close();

            if (transNum.Equals(0) )
            {
                
                var a = new startForm();
                a.Closed += (s, args) => this.Close();
                a.Show();
                this.Close();

            
            }*/

        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new salesFormEmployee();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        
    }
}
