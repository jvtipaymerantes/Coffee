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
        }


    }
}
