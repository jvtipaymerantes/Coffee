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
    public partial class ucInventoryEmployee : UserControl
    {
        public ucInventoryEmployee()
        {
            InitializeComponent();
        }

        private void ucInventoryEmployee_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = inventoryFormEmployee.prImage;
            textBox1.Text = inventoryFormEmployee.prCode;
            textBox2.Text = inventoryFormEmployee.prName;
            textBox3.Text = inventoryFormEmployee.prType;
        }
    }
}
