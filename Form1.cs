using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void add_Click(object sender, EventArgs e)
        {
            
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/");
            
        }
        private void divide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/");
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-");
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

        private void zero_Click(object sender, EventArgs e)
        {
            addNumberToTextField(zero.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = startingText;
        }
    }
}
