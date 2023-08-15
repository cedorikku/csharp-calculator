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

        private void num_Click(object sender, EventArgs e)
        {
            txtInput.Text += ((Control)sender).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        // Num Vars
        double firstNum, secondNum, result;
        string myOperator;
        private void btnOperation_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtInput.Text);
            myOperator = ((Control)sender).Text;
            txtInput.Clear();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // No operation means don't do anything
            if (String.IsNullOrEmpty(txtInput.Text))
            {
                return; // can end here
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
        }
    }
}
