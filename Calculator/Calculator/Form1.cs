using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double number1;
        private double number2;
        private string operation;
        private double result;

        internal double Number1
        {
            set { this.number1 = value;  }
            get { return number1;  }
        }

        internal double Number2
        {
            set { this.number2 = value; }
            get { return number2; }
        }

        internal string Operation
        {
            set { this.operation = value; }
            get { return operation; }
        }

        internal double Result
        {
            set { this.result = value; }
            get { return result; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtOperation.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text + "0";
            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text + "00";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "0.";
            }
            else
            {
                txtResult.Text = txtResult.Text + ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void btnSumision_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "+";
            txtOperation.Text = Convert.ToString(Number1) + Operation;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "-";
            txtOperation.Text = Convert.ToString(Number1) + Operation;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "*";
            txtOperation.Text = Convert.ToString(Number1) + Operation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "/";
            txtOperation.Text = Convert.ToString(Number1) + Operation;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "%";
            txtOperation.Text = Convert.ToString(Number1) + Operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(txtResult.Text);

            if (Operation == "+")
            {
                txtOperation.Text = txtOperation.Text + Convert.ToString(Number2);
                Result = (Number1 + Number2);
                txtResult.Text = Convert.ToString(Result);
                Number1 = Result;
            }

            else if (Operation == "-")
            {
                txtOperation.Text = txtOperation.Text + Convert.ToString(Number2);
                Result = (Number1 - Number2);
                txtResult.Text = Convert.ToString(Result);
                Number1 = Result;
            }

            else if (Operation == "*")
            {
                txtOperation.Text = txtOperation.Text + Convert.ToString(Number2);
                Result = (Number1 * Number2);
                txtResult.Text = Convert.ToString(Result);
                Number1 = Result;
            }

            else if (Operation == "/")
            {
                if (Number2 == 0)
                {
                    txtResult.Text = "Math Error!";
                }
                else
                {
                    txtOperation.Text = txtOperation.Text + Convert.ToString(Number2);
                    Result = (Number1 / Number2);
                    txtResult.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
            }

            else if (Operation == "%")
            {
                Result = (Number1 / 100);
                txtResult.Text = Convert.ToString(Result);
                Number1 = Result;
            }
        }
    }
}
