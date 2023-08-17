﻿using System;
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
            // Without an active operator, it will leave the state of the calculator as is
            if (String.IsNullOrEmpty(myOperator))
            {
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
        }

        // Algorithm for changing binary to decimal
        private void binaryToDecimalMode(string binaryText, int bits)
        {
            Queue<int> binaries = new Queue<int>();
            // Feed the binary numbers to a queue
            for (int i = 0; i <= bits; i++)
            {
                binaries.Enqueue(binaryText[i] - 48);
            }

            txtInput.Text = convertBinaryToDecimal(binaries, bits).ToString();
            operationSuccess = true;
        }

        // Algorithm for changing decimal to binary
        private void decimalToBinaryMode(string input)
        {
            txtInput.Clear();
            Stack<int> numbers = new Stack<int>();
            int inputNumber = Convert.ToInt32(input);

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

            while (numbers.Count != 0)
            {
                txtInput.AppendText(numbers.Pop().ToString());
            }

            operationSuccess = true;
        }

        // TODO Needs more comment
        private double convertBinaryToDecimal(Queue<int> bin, int bits)
        {
            if (bits == -1)
            {
                return 0;
            }

            int currentBit = bin.Dequeue();
            int value = (int)Math.Pow(2, bits);
            double converted = 0;

            if (currentBit == 1)
            {
                converted += value;
            }

            bits -= 1;
            return converted + convertBinaryToDecimal(bin, bits);
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            mode = 0;
            txtInput.Clear();
            toggleButtonVisibility(mode);

        }

        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            mode = 1;
            clearEverything();
            toggleButtonVisibility(mode);
        }

        // TODO Now
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
