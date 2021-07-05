using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coposProject
{
    public partial class ucAcc : UserControl
    {
        public ucAcc()
        {
            InitializeComponent();
        }

        private void ucAcc_Load(object sender, EventArgs e)
        {
            textBox1.Text = accounts.empId;
            textBox2.Text = accounts.empName;
            textBox3.Text = accounts.empPos;
            textBox4.Text = accounts.empUser;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

    }
}
