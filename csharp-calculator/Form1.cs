using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Used for checking if an operation was just executed or not
        bool operationSuccess = false;

        private void num_Click(object sender, EventArgs e)
        {
            if (operationSuccess == true)
            {
                operationSuccess = false;
                txtInput.Clear();
            }
            txtInput.Text += ((Control)sender).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            clearEverything();
        }

        private void clearEverything()
        {
            txtInput.Clear();
            myOperator = null;
            firstNum = 0;
            secondNum = 0;
        }

        // Num Vars
        private double firstNum, secondNum, result;
        private string myOperator;

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInput.Text))
            {
                myOperator = ((Control)sender).Text;
                return;
            }

            firstNum = Convert.ToDouble(txtInput.Text);
            myOperator = ((Control)sender).Text;
            txtInput.Clear();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // No operation means don't do anything
            if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrEmpty(myOperator))
            {
                return;
            }

            secondNum = Convert.ToDouble(txtInput.Text);

            // Switch that reads the operation symbol
            switch (myOperator)
            {
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
                case "*": result = firstNum * secondNum; break;
                case "/": result = firstNum / secondNum; break;
                default: return;
            }
            txtInput.Text = result.ToString();

            // Operation has ended so no operator is now used
            myOperator = null;
            // Turn the result as the next number to be operated on
            firstNum = result;

            operationSuccess = true;
        }

        // TODO Now
        private bool isButtonEnabled = true;
        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            clearEverything();

            if (isButtonEnabled)
            {
                isButtonEnabled = false;
            }
            else
            {
                isButtonEnabled = true;
            }
            
            toggleButtonVisibility(isButtonEnabled);
        }

        // TODO Later
        private void btnDecimalToBinary_Click(object sender, EventArgs e)
        {
            if (!isButtonEnabled)
            {
                isButtonEnabled = true;
                toggleButtonVisibility(isButtonEnabled);
            }
        }

        private void toggleButtonVisibility(bool state)
        {
            btn2.Enabled = state;
            btn3.Enabled = state;
            btn4.Enabled = state;
            btn5.Enabled = state;
            btn6.Enabled = state;
            btn7.Enabled = state;
            btn8.Enabled = state;
            btn9.Enabled = state;
            btnDecimalPoint.Enabled = state;
            btnAdd.Enabled = state;
            btnSubtract.Enabled = state;
            btnMultiply.Enabled = state;
            btnDivide.Enabled = state;
        }
    }
}
