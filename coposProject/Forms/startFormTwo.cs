using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace coposProject
{
    public partial class startFormTwo : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public startFormTwo()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void startFormTwo_Load(object sender, EventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string file = @"CS201.Michael.Dumala-CoPOS_3.pdf";
            Process.Start(file);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var startFormThree = new startFormThree();
            startFormThree.Closed += (s, args) => this.Close();
            startFormThree.Show();

        }


    }
}
