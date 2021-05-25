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
    public partial class ucReceiptPo : UserControl
    {

        public static ucReceiptPo currentOrderForm = null;

        public ucReceiptPo()
        {
            InitializeComponent();
        }

        public string TextBox1Value
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void ucReceiptPo_Load(object sender, EventArgs e)
        {
            textBox1.Text = orderHistoryForm.poId;
            textBox2.Text = orderHistoryForm.poEmployee;
            textBox3.Text = orderHistoryForm.poTotal;
            textBox4.Text = orderHistoryForm.poDate;
        }

        private void ucReceiptPo_MouseClick(object sender, MouseEventArgs e)
        {
            currentOrderForm = this;

            historyForm a = new historyForm();
            a.Show();



        }

    }
}
