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
    public partial class registerForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public registerForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //cmd.CommandText = "Insert into registration(employeeID,employee_name,position,username,password,question1,question2) Values('" + txtboxid.Text + "', '" + txtboxname.Text + "', '" + cboxposition.Text + "', '" + txtboxusern.Text + "', '" + txtboxpass.Text + "', '"  + txtboxquest1.Text + "', '" + txtboxquest2.Text + "') ";
            cmd.CommandText = " INSERT INTO registration(employeeID, employee_name, positionn, usernamee, passwordd, question1, question2) values('" + txtboxid.Text + "' , '" + txtboxname.Text + "', '" + cboxposition.Text.ToString() + "','" + txtboxusern.Text + "','" + txtboxpass.Text + "', '" + txtboxquest1.Text + "', '" + txtboxquest2.Text + "') "; 
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongTimeString();
            label9.Text = DateTime.Now.ToLongDateString(); 
        }
    }
}
