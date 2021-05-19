using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace coposProject
{
    public partial class purchaseForm : Form
    {
        public static string productCode;
        public static string productName;
        public static string productDescription;
        public static string productType;
        public static string productUnit;
        public static string productQuantity;
        public static string productCostperItem;
        public static string productExpDate;
        public static float productTotal;
        public static float overallTotal = 0;

        private OleDbConnection con = new OleDbConnection();
        public purchaseForm()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=coposDb.accdb";
        }

        private void purchaseForm_Load(object sender, EventArgs e)
        {
            textBox7.Text = overallTotal.ToString();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = true;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
            productType = "Coffee Bean";

            textBox6.Text = "COF";

        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = true;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
            productType = "Milk";

            textBox6.Text = "MLK";
        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = true;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
            productType = "Sugar";

            textBox6.Text = "SGR";

        }

        private void rectangleShape9_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = true;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;
            productType = "Tea";

            textBox6.Text = "TEA";

        }

        private void rectangleShape11_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = true;
            rectangleShape25.Visible = false;
            productType = "Syrup";

            textBox6.Text = "SYR";

        }

        private void rectangleShape24_Click(object sender, EventArgs e)
        {
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = true;
            productType = "Others";

            textBox6.Text = "OTH";

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

            productName = textBox1.Text;
            productCode = textBox6.Text;
            productDescription = textBox2.Text;

            StringBuilder unit = new StringBuilder();
            unit.Append(textBox3.Text);
            unit.Append(comboBox1.Text);
            productUnit = unit.ToString();

            productQuantity = textBox4.Text;
            productCostperItem = textBox5.Text;

            StringBuilder expDate = new StringBuilder();
            expDate.Append(comboBox2.Text + " ");
            expDate.Append(comboBox3.Text + " ");
            expDate.Append(comboBox4.Text);
            productExpDate = expDate.ToString();

            productTotal = float.Parse(productQuantity) * float.Parse(productCostperItem);
            
            overallTotal = overallTotal + productTotal;
            textBox7.Text = overallTotal.ToString();

            userControl.purchaseOrderUc uc = new userControl.purchaseOrderUc();
            flowLayoutPanel1.Controls.Add(uc);

            clearPurchaseForm();

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

            String imagelocation = "";
            try {
                
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                    imagelocation = dialog.FileName;
                    pictureBox19.ImageLocation = imagelocation;
                    panel32.Visible = false;
                }

            } catch(Exception){
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

        public void clearPurchaseForm()
        {
            textBox1.Clear();
            textBox6.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "UNIT";
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Text = "MONTH";
            comboBox3.Text = "DAY";
            comboBox4.Text = "YEAR";

            productType = "";
            rectangleShape4.Visible = false;
            rectangleShape6.Visible = false;
            rectangleShape8.Visible = false;
            rectangleShape10.Visible = false;
            rectangleShape12.Visible = false;
            rectangleShape25.Visible = false;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

            foreach(userControl.purchaseOrderUc uc in flowLayoutPanel1.Controls){
                MessageBox.Show(uc.TextBox1Value + " " + uc.TextBox2Value + " " + uc.TextBox3Value + " " + uc.TextBox4Value + " " + uc.TextBox5Value + " " + uc.TextBox6Value + " " + uc.TextBox7Value);
            }

            purchasePaymentForm a = new purchasePaymentForm();
            a.Show();



        }

        private void label30_Click(object sender, EventArgs e)
        {
            purchasePaymentForm a = new purchasePaymentForm();
            a.Show();
        }

        public string LabelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public void insertData(){

            foreach (userControl.purchaseOrderUc uc in flowLayoutPanel1.Controls)
            {
                MessageBox.Show(uc.TextBox1Value + " " + uc.TextBox2Value + " " + uc.TextBox3Value + " " + uc.TextBox4Value + " " + uc.TextBox5Value + " " + uc.TextBox6Value + " " + uc.TextBox7Value);
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = " INSERT INTO tblPurchaseReceipt(referenceNo, productCode, productName, productDescription, productCostPerItem, productQty, total, cashAmount, change) values('" + textBox1.Text + "', '" + uc.TextBox1Value.ToString() + "', '" + uc.TextBox2Value.ToString() + "', '" + uc.TextBox3Value.ToString() + "', '" + uc.TextBox6Value.ToString() + "', '" + uc.TextBox8Value.ToString() + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "') ";
                command.ExecuteNonQuery();

            }

            
        }


    }
}
