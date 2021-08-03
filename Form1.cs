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
        string startingText = "0";
        public Form1()
        {
            InitializeComponent();
        }
        private void addNumberToTextField(string number)
        {
            if (resultBox.Text.Length < 1 || resultBox.Text == startingText)
            {
                resultBox.Text = number;
            }
            else
            {
                resultBox.Text += number;
            }
           
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


            }

        }


        private void add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+");
        }
        private void subtract_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-");
            
        }
        private void divide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/");
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*");
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
           
        }
        private void clearEntirelyButton_Click(object sender, EventArgs e)
        { 
            resultBox.Text = startingText;
        }
        private void one_Click(object sender, EventArgs e)
        {
            addNumberToTextField(one.Text);
        }
        private void two_Click(object sender, EventArgs e)
        {
            addNumberToTextField(two.Text);
        }
        private void three_Click(object sender, EventArgs e)
        {
            addNumberToTextField(three.Text);
        }
        private void four_Click(object sender, EventArgs e)
        {
            addNumberToTextField(four.Text);
        }
        private void five_Click(object sender, EventArgs e)
        {
            addNumberToTextField(five.Text);
        }
        private void six_Click(object sender, EventArgs e)
        {
            addNumberToTextField(six.Text);
        }
        private void seven_Click(object sender, EventArgs e)
        {
            addNumberToTextField(seven.Text);
        }
        private void eight_Click(object sender, EventArgs e)
        {
            addNumberToTextField(eight.Text);
        }
        private void nine_Click(object sender, EventArgs e)
        {
            addNumberToTextField(nine.Text);
        }
        private void zero_Click(object sender, EventArgs e)
        {
            addNumberToTextField(zero.Text);
        }

        
    }
}
