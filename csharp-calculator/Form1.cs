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

        public Form1()
        {
            InitializeComponent();
        }

        // Used to help reset the textbox on keypress after a successful operation
        bool operationSuccess = false;

        // Used to avoid having duplicate decimal points
        int dotCounter = 0;
        private void num_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0" && ((Control)sender).Text == ".")
            {
                
            }
            else if (operationSuccess == true || txtInput.Text == "0")
            {
                operationSuccess = false;
                txtInput.Clear();
            }

            if (((Control)sender).Text == ".")
            {
                dotCounter++;
                if (dotCounter > 1)
                {
                    return;
                }
            }

            txtInput.Text += ((Control)sender).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            dotCounter = 0;
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
            dotCounter = 0;
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
            dotCounter = 0;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // No operation means don't do anything
            if (String.IsNullOrEmpty(txtInput.Text))
            {
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

        }

        // Returns the calculator back to being simple
        private void standardMode(string input)
        {
            // Without an active operator, it will do nothing
            if (String.IsNullOrEmpty(myOperator))
            {
                operationSuccess = true;
                return;
            }

            secondNum = Convert.ToDouble(input);

            // Switch that reads the operation symbol
            switch (myOperator)
            {
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
                case "*": result = firstNum * secondNum; break;
                case "/": result = firstNum / secondNum; break;
                default: return;
            }

            // Print the result
            txtInput.Text = result.ToString();

            // Operation has ended so no operator is now used
            myOperator = null;
            // Turn the result as the next number to be operated on
            firstNum = result;

            operationSuccess = true;
            dotCounter = 0;
        }

        // Algorithm for changing binary to decimal
        private void binaryToDecimalMode(string binaryText, int bits)
        {
            // Feed the binary numbers to a queue
            Queue<int> binaries = new Queue<int>();
            for (int i = 0; i <= bits; i++)
            {
                binaries.Enqueue(binaryText[i] - 48);
            }

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
            // Since append is used later. The current input needs to be cleared
            txtInput.Clear();
            
            // Feed the binary numbers to a stack
            int inputNumber = Convert.ToInt32(input);
            Stack<int> numbers = new Stack<int>();
            while (inputNumber > 0)
            {
                if (inputNumber % 2 == 0)
                {
                    numbers.Push(0);
                }
                else
                {
                    numbers.Push(1);
                }
                inputNumber /= 2;
            }

            // Appends the newly formed bits to the textbox from the stack
            while (numbers.Count != 0)
            {
                txtInput.AppendText(numbers.Pop().ToString());
            }

            operationSuccess = true;
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            mode = 0;
            txtInput.Text = "0";
            dotCounter = 0;
            toggleButtonVisibility(mode);

        }

        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            mode = 1;
            clearEverything();
            toggleButtonVisibility(mode);
        }

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
