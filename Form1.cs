using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string startingText = "0";
        private Double resultValue;

        private string operationUsed;
        private string numberUsed;

        private bool isOperationDone = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    e.Handled = true;
                    zero.PerformClick();
                    break;

                case Keys.NumPad1:
                    e.Handled = true;
                    one.PerformClick();
                    break;

                case Keys.NumPad2:
                    e.Handled = true;
                    two.PerformClick();
                    break;

                case Keys.NumPad3:
                    e.Handled = true;
                    three.PerformClick();
                    break;

                case Keys.NumPad4:
                    e.Handled = true;
                    four.PerformClick();
                    break;

                case Keys.NumPad5:
                    e.Handled = true;
                    five.PerformClick();
                    break;

                case Keys.NumPad6:
                    e.Handled = true;
                    six.PerformClick();
                    break;

                case Keys.NumPad7:
                    e.Handled = true;
                    seven.PerformClick();
                    break;

                case Keys.NumPad8:
                    e.Handled = true;
                    eight.PerformClick();
                    break;

                case Keys.NumPad9:
                    e.Handled = true;
                    nine.PerformClick();
                    break;

                case Keys.Back:
                    e.Handled = true;
                    clearButton.PerformClick();
                    break;

                case Keys.Decimal:
                    e.Handled = true;
                    comma.PerformClick();
                    break;

                case Keys.Add:
                    e.Handled = true;
                    add.PerformClick();
                    break;

                case Keys.Subtract:
                    e.Handled = true;
                    subtract.PerformClick();
                    break;

                case Keys.Multiply:
                    e.Handled = true;
                    multiply.PerformClick();
                    break;

                case Keys.Divide:
                    e.Handled = true;
                    divide.PerformClick();
                    break;

                case Keys.Delete:
                    e.Handled = true;
                    clearEntirelyButton.PerformClick();
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = startingText;
        }

        private void clearEntirelyButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = startingText;
            resultValue = 0;
            currentOperation.Text = "";
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            numberUsed = button.Text;
            addNumberToTextField(numberUsed);
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationUsed = button.Text;
            operatorAction(operationUsed);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            calculate(operationUsed);
        }

        private void operatorAction(string operatorType)
        {
            if (resultValue != 0)
            {
                equals.PerformClick();
                operationUsed = operatorType;
                resultValue = Double.Parse(resultBox.Text);
                currentOperation.Text = resultValue + " " + operatorType;
                isOperationDone = true;
            }
            operationUsed = operatorType;
            resultValue = Double.Parse(resultBox.Text);
            currentOperation.Text = resultValue + " " + operatorType;
            isOperationDone = true;
        }

        private void calculate(string operatorType)
        {
            switch (operatorType)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;

                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;

                case "*":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;

                case "/":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(resultBox.Text);
            currentOperation.Text = "";
        }

        private void addNumberToTextField(string number)
        {
            if (resultBox.Text == startingText || isOperationDone) resultBox.Clear();
            isOperationDone = false;
            if (number == ".")
            {
                if (!resultBox.Text.Contains(".")) resultBox.Text += number;
            }
            else
            {
                resultBox.Text += number;
            }
        }
    }
}