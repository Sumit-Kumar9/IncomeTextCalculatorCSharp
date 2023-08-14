using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeTexCalculator
{
    public partial class Form1 : Form
    {
        private object omtaxperiod;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Income Tax and Wages", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtemployers.Text = "";
            txtemployee.Text = "";

            compayment.Text = "";
            comtaxperiod.Text = "";
            comtaxcode.Text = "";
            comnicode.Text = "";

            txtrefrence.Text = "";
            txtincom.Text = "";
            txtpayment.Text = "";
            txtninumber.Text = "";
            txtpymdate.Text = "";
            txtgross.Text = "";
            txtdeduction.Text = "";
            txtnet.Text = "";

            Random random = new Random();
            txtrefrence.Text = Convert.ToString(random.Next(15224,9845213));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            txtrefrence.Text = Convert.ToString(random.Next(15224, 9845213));

            DateTime TDay = DateTime.Today;
            txtpymdate.Text = TDay.ToString("d");

            compayment.Items.Add(21000);
            compayment.Items.Add(42000);
            compayment.Items.Add(73000);
            compayment.Items.Add(89000);
            compayment.Items.Add(100000);
            compayment.Items.Add(1300000);
            compayment.Items.Add(1500000);

            comtaxperiod.Items.Add("Jan");
            comtaxperiod.Items.Add("Feb");
            comtaxperiod.Items.Add("Mar");
            comtaxperiod.Items.Add("Apr");
            comtaxperiod.Items.Add("May");
            comtaxperiod.Items.Add("Jun");
            comtaxperiod.Items.Add("Jul");
            comtaxperiod.Items.Add("Aug");
            comtaxperiod.Items.Add("Sep");
            comtaxperiod.Items.Add("Oct");
            comtaxperiod.Items.Add("Nov");
            comtaxperiod.Items.Add("Dec");

            comtaxcode.Items.Add("TC00117");
            comtaxcode.Items.Add("TC00217");
            comtaxcode.Items.Add("TC00317");
            comtaxcode.Items.Add("TC00417");
            comtaxcode.Items.Add("TC00517");
            comtaxcode.Items.Add("TC00617");
            comtaxcode.Items.Add("TC00717");

            comnicode.Items.Add("NIC51852");
            comnicode.Items.Add("NIC52852");
            comnicode.Items.Add("NIC53852");
            comnicode.Items.Add("NIC54852");
            comnicode.Items.Add("NIC55852");
            comnicode.Items.Add("NIC56852");
            comnicode.Items.Add("NIC57852");
            comnicode.Items.Add("NIC58852");
        }

        private void compayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double q, p, d, g, Taxdeducted, wagespaid,pay;
            pay = 21000;
            q = Convert.ToDouble(compayment.Text);
            if (q <= 21000)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 0) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if(q >= 21000 || q <= 42000)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 5) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if (q >= 42000 && q <= 73)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 10) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if (q >= 73000 && q<=89000)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 15) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if (q >= 89000 && q<= 100000)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 20) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if (q <= 100000 && q >= 130000 )
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 25) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
            else if (q <= 130000 && q >= 150000)
            {
                txtgross.Text = Convert.ToString(q);
                txtpayment.Text = Convert.ToString(q - pay);

                p = Convert.ToDouble(txtpayment.Text);
                Taxdeducted = (p * 30) / 100;
                txtdeduction.Text = Convert.ToString(Taxdeducted);

                txtincom.Text = Convert.ToString(pay);

                g = Convert.ToDouble(txtgross.Text);
                d = Convert.ToDouble(txtdeduction.Text);

                wagespaid = g - d;
                txtnet.Text = Convert.ToString(wagespaid);

                txtgross.Text = string.Format("{0:C}", g);
                txtdeduction.Text = string.Format("{0:C}", d);
                txtnet.Text = string.Format("{0:C}", wagespaid);
            }
        }
    }
}
