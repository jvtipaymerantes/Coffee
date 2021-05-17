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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var mainForm = new mainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
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
