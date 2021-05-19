using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coposProject.userControl
{
    public partial class purchaseOrderUc : UserControl
    {
        public purchaseOrderUc()
        {
            InitializeComponent();

        }

        private void purchaseOrderUc_Load(object sender, EventArgs e)
        {
            textBox1.Text = purchaseForm.productName;
            textBox2.Text = purchaseForm.productCode;
            textBox3.Text = purchaseForm.productDescription;
            textBox4.Text = purchaseForm.productType;
            textBox5.Text = purchaseForm.productUnit;
            textBox6.Text = purchaseForm.productCostperItem;
            textBox7.Text = purchaseForm.productExpDate;
        }

        private void purchaseOrderUc_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void purchaseOrderUc_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void rectangleShape1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }




    }
}
