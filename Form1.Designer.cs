
using System;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.clearEntirelyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.comma = new System.Windows.Forms.Button();
            this.currentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(681, 178);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 80);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(681, 267);
            this.subtract.Margin = new System.Windows.Forms.Padding(4);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(129, 80);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(72, 178);
            this.seven.Margin = new System.Windows.Forms.Padding(4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(139, 87);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(209, 178);
            this.eight.Margin = new System.Windows.Forms.Padding(4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(139, 87);
            this.eight.TabIndex = 3;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(347, 178);
            this.nine.Margin = new System.Windows.Forms.Padding(4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(139, 87);
            this.nine.TabIndex = 4;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(72, 267);
            this.four.Margin = new System.Windows.Forms.Padding(4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(139, 87);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(209, 267);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(139, 87);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(347, 267);
            this.six.Margin = new System.Windows.Forms.Padding(4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(139, 87);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(72, 355);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(139, 87);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(209, 355);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(139, 87);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(347, 355);
            this.three.Margin = new System.Windows.Forms.Padding(4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(139, 87);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(209, 443);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(139, 87);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(544, 267);
            this.multiply.Margin = new System.Windows.Forms.Padding(4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(129, 80);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(544, 178);
            this.divide.Margin = new System.Windows.Forms.Padding(4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(129, 80);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(544, 362);
            this.equals.Margin = new System.Windows.Forms.Padding(4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(266, 80);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // clearEntirelyButton
            // 
            this.clearEntirelyButton.Location = new System.Drawing.Point(818, 267);
            this.clearEntirelyButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearEntirelyButton.Name = "clearEntirelyButton";
            this.clearEntirelyButton.Size = new System.Drawing.Size(129, 80);
            this.clearEntirelyButton.TabIndex = 17;
            this.clearEntirelyButton.Text = "CE";
            this.clearEntirelyButton.UseVisualStyleBackColor = true;
            this.clearEntirelyButton.Click += new System.EventHandler(this.clearEntirelyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(818, 178);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 80);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(72, 98);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(875, 34);
            this.resultBox.TabIndex = 18;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(72, 67);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(64, 28);
            this.result.TabIndex = 19;
            this.result.Text = "Result";
            // 
            // comma
            // 
            this.comma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comma.Location = new System.Drawing.Point(347, 443);
            this.comma.Margin = new System.Windows.Forms.Padding(4);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(139, 87);
            this.comma.TabIndex = 20;
            this.comma.Text = ".";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.number_Click);
            // 
            // currentOperation
            // 
            this.currentOperation.AutoSize = true;
            this.currentOperation.Location = new System.Drawing.Point(883, 67);
            this.currentOperation.Name = "currentOperation";
            this.currentOperation.Size = new System.Drawing.Size(0, 28);
            this.currentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(996, 577);
            this.Controls.Add(this.currentOperation);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.clearEntirelyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clearEntirelyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Label currentOperation;
    }
}

