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

        //Value of Text Box (Code, Name, Description etc.)

        public string TextBox1Value
        {
            

            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string TextBox2Value
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string TextBox3Value
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string TextBox4Value
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string TextBox5Value
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string TextBox6Value
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public string TextBox7Value
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }

        public string TextBox8Value
        {
            get { return textBox8.Text; }
            set { textBox8.Text = value; }
        }

        public string TextBox9Value
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }

        public string imageLoc
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void purchaseOrderUc_Load(object sender, EventArgs e)
        {
            label1.Text = purchaseForm.imagelocation;
            textBox2.Text = purchaseForm.productCode;
            textBox1.Text = purchaseForm.productName;
            textBox3.Text = purchaseForm.productDescription;
            textBox4.Text = purchaseForm.productType;
            textBox5.Text = purchaseForm.productUnit;
            textBox6.Text = purchaseForm.productCostperItem;
            textBox7.Text = purchaseForm.productExpDate;
            textBox8.Text = purchaseForm.productQuantity;
            textBox9.Text = purchaseForm.productTotal.ToString();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //purchaseForm.flowLayoutPanel1.Controls.Remove(foundControl);
            //purchaseForm a = new purchaseForm();
            this.Parent.Controls.Remove(this);
        }

        private void purchaseOrderUc_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        


    }
}
