using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coposProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var inventory = new inventoryForm();
            inventory.Closed += (s, args) => this.Close();
            inventory.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new salesForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new purchaseForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new statisticsForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new accounts();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
                /* Open Form that prevents Object Disposed Exception */
                    this.Hide();
                    var a = new login();
                    a.Closed += (s, args) => this.Close();
                    a.Show();
       
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            label13.Text = DateTime.Now.ToShortDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

      

            

    }
}
