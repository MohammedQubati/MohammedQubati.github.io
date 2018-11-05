using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace institute
{
    public partial class Calculator : Form
    {
        double number1, number2, result;
        char op;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCal.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCal.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCal.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCal.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCal.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCal.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCal.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCal.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCal.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCal.Text += "0";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            txtCal.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCal.Text);
            op = '+';
            txtCal.Clear();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCal.Text);
            op = '-';
            txtCal.Clear();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCal.Text);
            op = '*';
            txtCal.Clear();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCal.Text);
            op = '/';
            txtCal.Clear();
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtCal.Text);
            switch(op)
            {
                case '+':
                    result = number1 + number2;break;
                case'-':
                    result=number1-number2;break;
                case'*':
                    result = number1 * number2;break;
                case'/':
                    result = number1 / number2;break;

            }
            txtCal.Text = Convert.ToString(result);
        }
    }
}
