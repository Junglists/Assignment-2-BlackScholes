using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS4620Black_Scholes_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string problem = null;

            try
            {
                problem = "Stock Price";
                double stockP = Convert.ToDouble(txtStockPrice.Text);
                problem = "Strike Price";
                double strikeP = Convert.ToDouble(txtStrikePrice.Text);
                problem = "Volatility";
                double volatility = Convert.ToDouble(txtVolatility.Text) / 100;
                problem = "Risk-Free Interest Rate";
                double riskR = Convert.ToDouble(txtRiskRate.Text) / 100;
                double dividents = 0;
                if (chkDividents.Checked == true)
                {
                    problem = "Dividents";
                    dividents = Convert.ToDouble(txtDivident.Text);
                }
                DateTime now = dateNow.Value;
                problem = "End Date";
                DateTime end = dateEnd.Value;
                double time = TotalDays(now, end);

                double d1, d2;
                d1 = (Math.Log(stockP / strikeP) + ((riskR - dividents + (volatility * volatility) / 2.0) * time)) / (volatility * Math.Sqrt(time));
                d2 = d1 - volatility * Math.Sqrt(time);

                double callprice = (stockP * std(d1)) - (std(d2) * strikeP * Math.Exp(-riskR * time));
                double putprice = strikeP * Math.Exp(-riskR * time) * std(-d2) - stockP * std(-d1);
                txtCallPrice.Text = callprice.ToString();
                txtPutPrice.Text = putprice.ToString();
                PerformCheck();

                double deltacallPrice = Math.Exp(-dividents * time) * std(d1);
                double deltaputPrice = Math.Exp(-dividents * time) * std(d1) - 1;
                double gammaPrice = Math.Exp(-dividents * time) * npdf(d1) / (stockP * volatility * Math.Sqrt(time));
                double vegaPrice = stockP * Math.Exp(-dividents * time) * npdf(d1) * Math.Sqrt(time);
                double thetacallPrice = -Math.Exp(-dividents * time) * (stockP * npdf(d1) * volatility / (2 * Math.Sqrt(time))) - riskR * strikeP * Math.Exp(-riskR * time) * npdf(d2) + dividents * stockP * Math.Exp(-dividents * time) * npdf(d1);
                double thetaputPrice = -Math.Exp(-dividents * time) * (stockP * npdf(d1) * volatility / (2 * Math.Sqrt(time))) + riskR * strikeP * Math.Exp(-riskR * time) * npdf(-d2) - dividents * stockP * Math.Exp(-dividents * time) * npdf(-d1);

                dCall.Text = deltacallPrice.ToString("#0.00000");
                dPut.Text = deltaputPrice.ToString("#0.00000");
                gCall.Text = gammaPrice.ToString("#0.00000");
                gPut.Text = gammaPrice.ToString("#0.00000");
                vCall.Text = vegaPrice.ToString("#0.00000");
                vPut.Text = vegaPrice.ToString("#0.00000");
                tCall.Text = thetacallPrice.ToString("#0.00000");
                tPut.Text = thetaputPrice.ToString("#0.00000");

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid " + problem + " input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //function phi
        private double npdf(double x)
        {
            double phi = 0.0;

            phi = Math.Exp(-x * x / 2) / Math.Sqrt(2 * Math.PI);
            return phi;
        }

        private void PerformCheck()
        {
            if (chkCall.Checked == true)
            {
                txtCallPrice.Show(); label7.Show();
            }
            else
            {
                txtCallPrice.Hide(); label7.Hide();

            }

            if (chkPut.Checked == true)
            {
                txtPutPrice.Show(); label8.Show();
            }
            else
            {
                txtPutPrice.Hide(); label8.Hide();
            }
        }

        private static double TotalDays(DateTime d1, DateTime d2)
        {
            TimeSpan span = d2.Subtract(d1);
            double span1 = span.Days;

            return span1 / 365;


        }

        public static double std(double x)
        {
            const double SqrtTwoPiInv = 0.398942280401433;

            if (x < 0)
                return 1.0 - std(-x);
            const double num0 = 0.2316419;
            const double num1 = 0.319381530;
            const double num2 = -0.356563782;
            const double num3 = 1.781477937;
            const double num4 = -1.821255978;
            const double num5 = 1.330274429;
            double pdf = SqrtTwoPiInv * Math.Exp(-0.5 * x * x);
            double a = 1.0 / (1.0 + num0 * x);
            return 1.0 - pdf * (num1 * a + num2 * Math.Pow(a, 2) + num3 * Math.Pow(a, 3) + num4 * Math.Pow(a, 4) + num5 * Math.Pow(a, 5));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPutPrice.ReadOnly = true;
            txtCallPrice.ReadOnly = true;
            txtCallPrice.Hide();
            txtPutPrice.Hide();
            txtDivident.Hide();
            label7.Hide();
            label8.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            lblDelta.Hide();
            lblGamma.Hide();
            lblVega.Hide();
            lblTheta.Hide();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCallPrice.Text = "";
            txtPutPrice.Text = "";
            txtRiskRate.Text = "";
            txtStockPrice.Text = "";
            txtStrikePrice.Text = "";
            txtVolatility.Text = "";
            chkCall.Checked = false;
            chkPut.Checked = false;
            chkDividents.Checked = false;
            chkGreek.Checked = false;
            dateNow.ResetText();
            dateEnd.ResetText();
            txtCallPrice.Hide();
            txtPutPrice.Hide();
            txtDivident.Hide();
            label7.Hide();
            label8.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            lblDelta.Hide();
            lblGamma.Hide();
            lblVega.Hide();
            lblTheta.Hide();
        }

        private void chkDividents_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDividents.Checked == true){
                txtDivident.Show();}
            if (chkDividents.Checked == false){
                txtDivident.Hide(); txtDivident.Text = "";
            }    
        }

        private void chkGreek_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreek.Checked == true)
            {
                groupBox4.Show();
                groupBox5.Show();
                lblDelta.Show();
                lblGamma.Show();
                lblVega.Show();
                lblTheta.Show();
            }
            if (chkGreek.Checked == false)
            {
                groupBox4.Hide();
                groupBox5.Hide();
                lblDelta.Hide();
                lblGamma.Hide();
                lblVega.Hide();
                lblTheta.Hide(); 
            }
        }














    }
}
