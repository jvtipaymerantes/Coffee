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
    public partial class forgotpasswordFormTwo : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public forgotpasswordFormTwo()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void forgotpasswordFormTwo_Load(object sender, EventArgs e)
        {
           

        }

        public void label1_Click(object sender, EventArgs e)
        {


            if (txtboxconfirm1.Text == txtboxconfirm2.Text)
            {

                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                //cmd.CommandText = "Insert into registration(employeeID,employee_name,position,username,password,question1,question2) Values('" + txtboxid.Text + "', '" + txtboxname.Text + "', '" + cboxposition.Text + "', '" + txtboxusern.Text + "', '" + txtboxpass.Text + "', '"  + txtboxquest1.Text + "', '" + txtboxquest2.Text + "') ";
                //cmd.CommandText = "UPDATE Student(LastName, FirstName, Address, City) VALUES (@ln, @fn, @add, @cit) WHERE LastName='" + lastName + "' AND FirstName='" + firstName + "'";
                cmd.CommandText = " UPDATE registration SET [employeePassword]='" + txtboxconfirm2.Text + "' WHERE employeeUsername =  '"+ forgotpasswordForm.username +"' ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated", "Congrats");
                con.Close();
            }

            else
            {
                MessageBox.Show("Password not match, please try again");
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }


    }
}
