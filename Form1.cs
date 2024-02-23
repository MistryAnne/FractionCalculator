using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            int firstNum = 0;
            int secondNum = 0;
            int firstDen = 0;
            int secondDen = 0;
            int resultNum = 0;
            int resultDen = 0;

            try
            {
                firstNum = int.Parse(txtFirstNum.Text);
                secondNum = int.Parse(txtSecondNum.Text);
                firstDen = int.Parse(txtFirstDen.Text);
                secondDen = int.Parse(txtSecondDen.Text);
                Fraction first = new Fraction(firstNum, firstDen);
                Fraction second = new Fraction(secondNum, secondDen);
                Fraction result = new Fraction();
                if (rbtnAddition.Checked)
                {
                    result = Fraction.Add(first, second);
                    result = Fraction.Simplify(result);
                    resultNum = result.Numerator;
                    resultDen = result.Denominator;
                }
                else
                if (rbtnSubtraction.Checked)
                {
                    result = Fraction.Subtract(first, second);
                    result = Fraction.Simplify(result);
                    resultNum = result.Numerator;
                    resultDen = result.Denominator;
                }
                else
                if (rbtnMultiplication.Checked)
                {
                    result = Fraction.Multiply(first, second);
                    result = Fraction.Simplify(result);
                    resultNum = result.Numerator;
                    resultDen = result.Denominator;
                }
                else
                if (rbtnDivision.Checked)
                {
                    result = Fraction.Divide(first, second);
                    result = Fraction.Simplify(result);
                    resultNum = result.Numerator;
                    resultDen = result.Denominator;
                }

                txtResultNum.Text = resultNum.ToString();
                txtResultDen.Text = resultDen.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                txtResultNum.Text = "NA";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                txtResultNum.Text = "DIV 0";
            }
        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtFirstDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtSecondDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
    }
}
