using System;
using System.Collections;
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
        Font smallBoldFont = new Font("Segoe UI", 18.5f, FontStyle.Bold);
        Font bigBoldFont = new Font("Segoe UI", 32.5f, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            lblMode.Text = "Standard";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        // Keybinds
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Operators
            switch (e.KeyChar)
            {
                // numeric
                case (char)Keys.D0: btn0.PerformClick(); break;
                case (char)Keys.D1: btn1.PerformClick(); break;
                case (char)Keys.D2: btn2.PerformClick(); break;
                case (char)Keys.D3: btn3.PerformClick(); break;
                case (char)Keys.D4: btn4.PerformClick(); break;
                case (char)Keys.D5: btn5.PerformClick(); break;
                case (char)Keys.D6: btn6.PerformClick(); break;
                case (char)Keys.D7: btn7.PerformClick(); break;
                case (char)Keys.D8: btn8.PerformClick(); break;
                case (char)Keys.D9: btn9.PerformClick(); break;
                case '.': btnDecimalPoint.PerformClick(); break;
                // Edit
                case (char)Keys.Escape: btnClear.PerformClick(); break;
                case 'c': btnClearEntry.PerformClick(); break;
                case (char)Keys.Back: btnBackspace.PerformClick(); break;
                // Operators
                case '+': btnAdd.PerformClick(); break;
                case '-': btnSubtract.PerformClick(); break;
                case '*': btnMultiply.PerformClick(); break;
                case '/': btnDivide.PerformClick(); break;
                // Execute
                case '=': btnExecute.PerformClick(); break;
            }
        }

        // Used to help reset the textbox on keypress after a successful operation
        bool operationSuccess = false;

        // Used to avoid having duplicate decimal points
        private void num_Click(object sender, EventArgs e)
        {
            txtInput.Font = bigBoldFont;

            // Prevents duplication of the decimal point
            if (operationSuccess && ((Control)sender).Text == ".")
            {
                txtInput.Text = "0";
            }
            else if (txtInput.Text.Contains(".") && ((Control)sender).Text == ".")
            {
                return;
            }

            // Decimal point will follow after a 0
            // Else, it will remove leading 0 automatically
            if (txtInput.Text == "0" && ((Control)sender).Text == ".")
            {
                operationSuccess = false;
                txtInput.Text = "0";
            }
            else if (operationSuccess || txtInput.Text == "0")
            {
                operationSuccess = false;
                txtInput.Clear();
            }

            // Prevents typing more than 14 digits
            if (txtInput.Text.Length > 14)
            {
                return;
            }

            if (String.IsNullOrEmpty(myOperator))
            {
                txtIndicator.Clear();
            }

            txtInput.Text += ((Control)sender).Text;

            btnExecute.Focus();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (operationSuccess)
            {
                firstNum = 0;
                secondNum = 0;
                txtIndicator.Clear();
                myOperator = null;
            }

            txtInput.Font = bigBoldFont;
            txtInput.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearEverything();
        }

        private void clearEverything()
        {
            btnClearEntry.PerformClick();
            txtIndicator.Clear();
            myOperator = null;
            firstNum = 0;
            secondNum = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            // Prevents backspace on these conditions
            if (operationSuccess || txtInput.Text == "0")
            {
                return;
            }

            int inputLength = txtInput.Text.Length;
            txtInput.Text = txtInput.Text.Substring(0, inputLength - 1);

            if (String.IsNullOrEmpty(txtInput.Text))
            {
                txtInput.Text = "0";
            }

            btnExecute.Focus();
        }

        // Num Vars
        private double firstNum, secondNum, result;
        private string myOperator;

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "undefined")
            {
                return;
            }

            if (!String.IsNullOrEmpty(myOperator))
            {
                btnExecute.PerformClick();
            }

            firstNum = Convert.ToDouble(txtInput.Text);
            myOperator = ((Control)sender).Text;

            if (!String.IsNullOrEmpty(myOperator))
            {
                txtIndicator.Text = txtInput.Text + " " + ((Control)sender).Text;
            }

            txtInput.Text = "0";

            btnExecute.Focus();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "undefined")
            {
                btnClear.PerformClick();
                return;
            }

            // Very special case where they enter "0."
            if (txtInput.Text == "0.")
            {
                txtIndicator.Text = "0 = ";
                txtInput.Text = "0";
                operationSuccess = true;
                return;
            }

            string input = txtInput.Text;
            switch (mode)
            {
                case 0: 
                    standardMode(input); 
                    break;
                case 1:
                    int bits = input.Length - 1;
                    binaryToDecimalMode(input, bits); 
                    break;
                case 2:
                    decimalToBinaryMode(input);
                    break;
            }

            if (txtInput.Text.Length > 14) 
            {
                txtInput.Font = smallBoldFont;
            }

            btnExecute.Focus();
        }

        // Returns the calculator back to being simple
        private void standardMode(string input)
        {
            // Without an active operator, it will do nothing
            if (String.IsNullOrEmpty(myOperator))
            {
                txtIndicator.Text = txtInput.Text + " =";
                operationSuccess = true;
                return;
            }

            secondNum = Convert.ToDouble(input);
            txtIndicator.AppendText(" " + secondNum.ToString() + " =");

            // Switch that reads the operation symbol
            switch (myOperator)
            {
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
                case "*": result = firstNum * secondNum; break;
                case "/": result = firstNum / secondNum; break;
                default: return;
            }

            // Prevents dividing by 0 which causes undefined
            if (myOperator == "/" && txtInput.Text == "0")
            {
                txtInput.Text = "undefined";
                myOperator = null;
                operationSuccess = true;
                return;
            }

            // Print the result
            txtInput.Text = result.ToString();

            // Operation has ended so no operator is now used
            myOperator = null;
            // Turn the result as the next number to be operated on
            firstNum = result;

            operationSuccess = true;
        }

        // Algorithm for changing binary to decimal
        private void binaryToDecimalMode(string binaryText, int bits)
        {
            if (operationSuccess)
            {
                return;
            }

            // Feed the binary numbers to a queue
            Queue<int> binaries = new Queue<int>();
            for (int i = 0; i <= bits ; i++)
            {
                binaries.Enqueue(binaryText[i] - 48);
            }

            txtIndicator.Text = txtInput.Text + " =";
            txtInput.Text = convertBinaryToDecimal(binaries, bits).ToString();
            operationSuccess = true;
        }
        // Binary to Decimal Conversion (Recursion). Returns the converted value
        private double convertBinaryToDecimal(Queue<int> bin, int bits)
        {
            // Recursion stops when there are no more numbers to work with
            if (bits == -1)
            {
                return 0;
            }

            // Takes current bit to work with. 0 or 1 as a value
            int currentBit = bin.Dequeue();
            // Assign a value to the bit, based on the its position
            int value = Convert.ToInt32(Math.Pow(2, bits));
            
            // If the current bit is 0, lightbulb off, it has no value
            // If the current bit is 1, lighbulb on, it will add its value on the overall value
            double approvedValue = 0;
            if (currentBit == 1)
            {
                approvedValue += value;
            }

            // The bits continue to grow smaller for every iteration
            bits -= 1;

            return approvedValue + convertBinaryToDecimal(bin, bits);
        }

        // Algorithm for changing decimal to binary
        private void decimalToBinaryMode(string input)
        {
            if (operationSuccess)
            {
                return;
            }

            long inputNumber = Convert.ToInt64(input);
            string outputNumber = "";

            while (inputNumber > 0)
            {
                if (inputNumber % 2 == 0)
                {
                    outputNumber = 0 + outputNumber;
                }
                else
                {
                    outputNumber = 1 + outputNumber;
                }

                inputNumber /= 2;
            }

            txtIndicator.Text = txtInput.Text + " =";
            txtInput.Text = outputNumber;
            operationSuccess = true;
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            mode = 0;
            lblMode.Text = "Standard";
            clearEverything();
            toggleButtonVisibility(mode);
        }

        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            mode = 1;
            lblMode.Text = "Binary To Decimal";
            clearEverything();
            toggleButtonVisibility(mode);
        }

        private void btnDecimalToBinary_Click(object sender, EventArgs e)
        {
            mode = 2;
            lblMode.Text = "Decimal To Binary";
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
                case 1: // Binary to Decimal mode
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
                case 2: // Decimal to Binary mode
                    btnDecimalPoint.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSubtract.Enabled = false;
                    btnMultiply.Enabled = false;
                    btnDivide.Enabled = false;
                    break;
                default:  
                    break;
            }
        }
    }
}
