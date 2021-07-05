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
    public partial class shadowBg : Form
    {

        public static shadowBg currentShadow = null;

        public shadowBg()
        {
            InitializeComponent();
        }

        private void shadowBg_Load(object sender, EventArgs e)
        {
            currentShadow = this;
        }
    }
}
