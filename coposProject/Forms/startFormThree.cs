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
    public partial class startFormThree : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public startFormThree()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void startFormThree_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //cmd.CommandText = "Insert into registration(employeeID,employee_name,position,username,password,question1,question2) Values('" + txtboxid.Text + "', '" + txtboxname.Text + "', '" + cboxposition.Text + "', '" + txtboxusern.Text + "', '" + txtboxpass.Text + "', '"  + txtboxquest1.Text + "', '" + txtboxquest2.Text + "') ";
            cmd.CommandText = " INSERT INTO registration(employeeID, employeeName, employeePosition, employeeUsername, employeePassword, question1, question2) values('" + txtboxid.Text + "' , '" + txtboxname.Text + "', '" + cboxposition.Text.ToString() + "','" + txtboxusern.Text + "','" + txtboxpass.Text + "', '" + txtboxquest1.Text + "', '" + txtboxquest2.Text + "') "; 
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            con.Close();

            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();


        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }


    }
}
