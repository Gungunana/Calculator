﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0d;
        double num2 = 0d;
        int selectionStart = 0;
        bool txtBoxNum1Selected = true;

        string keepTextFromTextBox = "";

        string pattern = @"\-?[0-9][0-9]*[,]?[0-9]*";  
        string currentNumberTextBox1 = "";
        string currentNumberTextBox2 = "";

        char currentCultureDecimalMark = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public Form1()
        {
            InitializeComponent();
            textBoxNum1.Select();
            if (currentCultureDecimalMark == '.')
            {
                btnDecimalMark.Text = ".";
                pattern = @"\-?[0-9][0-9]*[.]?[0-9]*";
            }
        }

        public double Sum(string a, string b)
        {
            if (a != "" && b != "")
            {
                num1 = double.Parse(a);
                num2 = double.Parse(b);
                return num1 + num2;
            }
            else
            {
                return 0;
            }    
        }
        public double Multiply(string a, string b)
        {
            if (a != "" && b != "")
            {
                num1 = double.Parse(a);
                num2 = double.Parse(b);
                return num1 * num2;
            }
            else
            {
                return 0;
            }
        }
        public double Substract(string a, string b)
        {
            if (a != "" && b != "")
            {
                num1 = double.Parse(a);
                num2 = double.Parse(b);
                return num1 - num2;
            }
            else
            {
                return 0;
            }
        }
        public double Divide(string a, string b)
        {
            if (a != "" && b != "")
            {
                num1 = double.Parse(a);
                num2 = double.Parse(b);
                try
                {
                    double catchDivideByZeroException = num1 / num2;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Can't divide by zero!");
                }
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }
         
        public void MoveSelectorToEmptyTextBox()
        {
            if (textBoxNum1.Text == "" && textBoxNum2.Text == "")
            {
                textBoxNum1.Select();
            }
            else if (textBoxNum1.Text == "")
            {
                textBoxNum1.Select();
            }
            else if (textBoxNum2.Text == "")
            {
                textBoxNum2.Select();
            }
        }

        public void AppendNumberFromNumPad(string num)
        {
            if (txtBoxNum1Selected)
            {
                selectionStart = textBoxNum1.SelectionStart;
                textBoxNum1.Text = textBoxNum1.Text.Insert(selectionStart, num);
                textBoxNum1.SelectionStart = selectionStart + 1;
            }
            else
            {
                selectionStart = textBoxNum2.SelectionStart;
                textBoxNum2.Text = textBoxNum2.Text.Insert(selectionStart, num);
                textBoxNum2.SelectionStart = selectionStart + 1;
            }
        }

        public void PreserveSelectedTextBoxSelection()
        {
            if (txtBoxNum1Selected)
            {
                textBoxNum1.Select();
            }
            else
            {
                textBoxNum2.Select();
            }
        }

        public void LabelText(string buttonOperation)
        {
            lblOperation.Text = buttonOperation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelText(btnAdd.Text);
            MoveSelectorToEmptyTextBox();
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(textBoxNum1.Text);
            if (textBoxNum1.Text != match.Groups[0].ToString())
            {
                textBoxNum1.Text = currentNumberTextBox1;
                textBoxNum1.SelectionStart = textBoxNum1.Text.Length;
            }
            else
            {
                currentNumberTextBox1 = textBoxNum1.Text;
            }            
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(textBoxNum2.Text);
            if (textBoxNum2.Text != match.Groups[0].ToString())
            {
                textBoxNum2.Text = currentNumberTextBox2;
                textBoxNum2.SelectionStart = textBoxNum2.Text.Length;
            }
            else
            {
                currentNumberTextBox2 = textBoxNum2.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            LabelText(btnMultiply.Text);
            MoveSelectorToEmptyTextBox();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            LabelText(btnSubstract.Text);
            MoveSelectorToEmptyTextBox();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            LabelText(btnDivide.Text);
            MoveSelectorToEmptyTextBox();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (lblOperation.Text != "")
            {
                if (textBoxNum1.Text == "")
                {
                    textBoxNum1.Text = "0";
                }
                if (textBoxNum2.Text == "")
                {
                    textBoxNum2.Text = "0";
                }
                switch (lblOperation.Text)
                {
                    case "+": textBoxResult.Text = Sum(textBoxNum1.Text, textBoxNum2.Text).ToString(); break;
                    case "-": textBoxResult.Text = Substract(textBoxNum1.Text, textBoxNum2.Text).ToString(); break;
                    case "*": textBoxResult.Text = Multiply(textBoxNum1.Text, textBoxNum2.Text).ToString(); break;
                    case "/": textBoxResult.Text = Divide(textBoxNum1.Text, textBoxNum2.Text).ToString(); break;
                    default:
                        break;
                }
                lblAction.Text = $"{textBoxNum1.Text} {lblOperation.Text} {textBoxNum2.Text}";
                textBoxNum1.Text = "";
                textBoxNum2.Text = "";
                lblOperation.Text = "";
                lblNum1.Text = "";
                lblNum2.Text = "";
                textBoxNum1.Text = textBoxResult.Text;
                textBoxNum2.Select();
            }
        }

        private void btnClearCurrent_Click(object sender, EventArgs e)
        {
            if (txtBoxNum1Selected)
            {
                textBoxNum1.Text = "";
                textBoxNum1.Select();
            }
            else
            {
                textBoxNum2.Text = "";
                textBoxNum2.Select();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
            textBoxResult.Text = "";
            lblAction.Text = "";
            lblOperation.Text = "";
            lblNum1.Text = "";
            lblNum2.Text = "";
            textBoxNum1.Select();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    {
                        btnAdd.Select();
                        btnAdd.PerformClick();
                    }
                    break;
                case Keys.Subtract: btnSubstract.PerformClick(); break;
                case Keys.Multiply: btnMultiply.PerformClick(); break;
                case Keys.Divide: btnDivide.PerformClick(); break;
                case Keys.Enter: btnResult.PerformClick(); break;
                case Keys.Clear: btnDeleteOneDigit.PerformClick(); break;
                default:
                    break;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lblOperation.Text)
                {
                    case "+": textBoxResult.Text = (double.Parse(textBoxNum2.Text) / 100 * double.Parse(textBoxNum1.Text)).ToString(); break;
                    case "-": textBoxResult.Text = (double.Parse(textBoxNum2.Text) / 100 * double.Parse(textBoxNum2.Text)).ToString(); break;
                    case "*": textBoxResult.Text = (Multiply(textBoxNum1.Text, textBoxNum2.Text) / 100).ToString(); break;
                    case "/": textBoxResult.Text = (Divide(textBoxNum1.Text, textBoxNum2.Text) * 100).ToString() + " %"; break;
                    default:
                        break;
                }
                lblAction.Text = "";
            }
            catch (FormatException)
            {
                PreserveSelectedTextBoxSelection(); 
            }
            
        }

        private void lblAction_Click(object sender, EventArgs e)
        {

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNum1Selected)
                {
                    keepTextFromTextBox = textBoxNum1.Text;
                    textBoxNum1.Text = Math.Sqrt(double.Parse(textBoxNum1.Text)).ToString();
                    lblNum1.Text = $"Sqrt({keepTextFromTextBox})";
                }
                else
                {
                    keepTextFromTextBox = textBoxNum2.Text;
                    textBoxNum2.Text = Math.Sqrt(double.Parse(textBoxNum2.Text)).ToString();
                    lblNum2.Text = $"Sqrt({keepTextFromTextBox})";
                }
            }
            catch (FormatException)
            {
                PreserveSelectedTextBoxSelection();
            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNum1Selected)
                {
                    keepTextFromTextBox = textBoxNum1.Text;
                    textBoxNum1.Text = (double.Parse(textBoxNum1.Text) * (-1)).ToString();
                    lblNum1.Text = $"Negate({keepTextFromTextBox})";
                }
                else
                {
                    keepTextFromTextBox = textBoxNum2.Text;
                    textBoxNum2.Text = (double.Parse(textBoxNum2.Text) * (-1)).ToString();
                    lblNum2.Text = $"Negate({keepTextFromTextBox})";
                }
            }
            catch (FormatException)
            {
                PreserveSelectedTextBoxSelection();
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNum1Selected)
                {
                    keepTextFromTextBox = textBoxNum1.Text;
                    textBoxNum1.Text = (1 / double.Parse(textBoxNum1.Text)).ToString();
                    lblNum1.Text = $"Reciprocal({keepTextFromTextBox})";
                }
                else
                {
                    keepTextFromTextBox = textBoxNum2.Text;
                    textBoxNum2.Text = (1 / double.Parse(textBoxNum2.Text)).ToString();
                    lblNum2.Text = $"Reciprocal({keepTextFromTextBox})";
                }
            }
            catch (FormatException)
            {
                PreserveSelectedTextBoxSelection();
            }
        }

        private void btnNumPad1_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("1");
        }

        private void textBoxNum1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxNum1_Enter(object sender, EventArgs e)
        {
            txtBoxNum1Selected = true;
        }

        private void textBoxNum2_Enter(object sender, EventArgs e)
        {
            txtBoxNum1Selected = false;
        }

        private void btnNumPad2_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("2");
        }

        private void btnNumPad3_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("3");
        }

        private void btnNumPad4_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("4");
        }

        private void btnNumPad5_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("5");
        }

        private void btnNumPad6_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("6");
        }

        private void btnNumPad7_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("7");
        }

        private void btnNumPad8_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("8");
        }

        private void btnNumPad9_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("9");
        }

        private void btnNumPad0_Click(object sender, EventArgs e)
        {
            AppendNumberFromNumPad("0");
        }

        private void btnDecimalMark_Click(object sender, EventArgs e)
        {
            if (!textBoxNum1.Text.Contains(currentCultureDecimalMark.ToString()))
            {
                AppendNumberFromNumPad(currentCultureDecimalMark.ToString());
            }
            else if (!textBoxNum2.Text.Contains(currentCultureDecimalMark.ToString()))
            {
                AppendNumberFromNumPad(currentCultureDecimalMark.ToString());
            }
        }

        private void btnDeleteLastDigit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNum1Selected)
                {
                    selectionStart = textBoxNum1.SelectionStart;
                    textBoxNum1.Text = textBoxNum1.Text.Remove(selectionStart - 1, 1);
                    textBoxNum1.SelectionStart = selectionStart - 1;
                }
                else
                {
                    selectionStart = textBoxNum2.SelectionStart;
                    textBoxNum2.Text = textBoxNum2.Text.Remove(selectionStart - 1, 1);
                    textBoxNum2.SelectionStart = selectionStart - 1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                PreserveSelectedTextBoxSelection();
            } 
        }
    }
}