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
    public partial class startForm : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public startForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Select Count(*) from registration";
            command.ExecuteNonQuery();
            int transNum = (int)command.ExecuteScalar();
            con.Close();

            if (transNum > 0)
            {
                /* Open Form that prevents Object Disposed Exception */
                this.Hide();
                var a = new login();
                a.Closed += (s, args) => this.Close();
                a.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var startFormTwo = new startFormTwo();
            startFormTwo.Closed += (s, args) => this.Close();
            startFormTwo.Show();
        }


    }
}
