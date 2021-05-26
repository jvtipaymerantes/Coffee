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
    public partial class ucSales : UserControl
    {
        public ucSales()
        {
            InitializeComponent();
        }

        private void ucSales_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = salesForm.prImage;
        }
    }
}
