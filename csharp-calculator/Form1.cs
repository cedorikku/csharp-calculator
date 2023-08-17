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
        int mode; // swaps between calculator modes

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

            if (mode == 0)
            {
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
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            mode = 0;
            txtInput.Clear();
            toggleButtonVisibility(mode);

        }

        // TODO Now
        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            mode = 1;
            clearEverything();
            toggleButtonVisibility(mode);
        }

        // TODO Later
        private void btnDecimalToBinary_Click(object sender, EventArgs e)
        {
            mode = 2;
            clearEverything();
            toggleButtonVisibility(mode);
        }

        private void toggleButtonVisibility(int mode)
        {
            // Standard mode
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnDecimalPoint.Enabled = true;
            btnAdd.Enabled = true;
            btnSubtract.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;

            // Other modes
            switch (mode)
            {
                case 1:
                    {
                        btn2.Enabled = false;
                        btn3.Enabled = false;
                        btn4.Enabled = false;
                        btn5.Enabled = false;
                        btn6.Enabled = false;
                        btn7.Enabled = false;
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                        btnDecimalPoint.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSubtract.Enabled = false;
                        btnMultiply.Enabled = false;
                        btnDivide.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        btnDecimalPoint.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSubtract.Enabled = false;
                        btnMultiply.Enabled = false;
                        btnDivide.Enabled = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
