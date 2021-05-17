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
    public partial class purchaseForm : Form
    {
        public purchaseForm()
        {
            InitializeComponent();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = true;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = true;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = true;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
        }

        private void rectangleShape9_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = true;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = true;
            rectangleShape25.Visible = false;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void rectangleShape25_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new mainForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new inventoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new salesForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new orderHistoryForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new statisticsForm();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            /* Open Form that prevents Object Disposed Exception */
            this.Hide();
            var a = new accounts();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            userControl.purchaseOrderUc a = new userControl.purchaseOrderUc();
            flowLayoutPanel1.Controls.Add(a);

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

            String imagelocation = "";
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*|";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox19.ImageLocation = imagelocation;
                }

            }catch(Exception){
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            pictureBox17.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            label18.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panel32.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.White;
            pictureBox17.BackColor = Color.White;
            label18.BackColor = Color.White;
            panel32.BackColor = Color.White;
        }

        




    }
}
