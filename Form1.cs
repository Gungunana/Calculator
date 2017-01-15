using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double catchFormatException;
        double num1 = 0d;
        double num2 = 0d;
        int selectionStart = 0;
        bool txtBoxNum1Selected = true;

        char currentCultureDecimalMark = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        //CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSepar‌​ator

        public Form1()
        {
            InitializeComponent();
            textBoxNum1.Select();
            if (currentCultureDecimalMark == '.')
            {
                btnDecimalMark.Text = ".";
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
            try
            {
                catchFormatException = double.Parse(textBoxNum1.Text);
            }
            catch (FormatException)
            {
                try
                {
                    textBoxNum1.Text = textBoxNum1.Text.Remove(textBoxNum1.Text.Length - 1, 1);
                    textBoxNum1.Focus();
                    textBoxNum1.SelectionStart = textBoxNum1.Text.Length;
                }
                catch (Exception)
                {
                    textBoxNum1.Text = "";
                }
            }
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                catchFormatException = double.Parse(textBoxNum2.Text);
            }
            catch (FormatException)
            {
                try
                {
                    textBoxNum2.Text = textBoxNum2.Text.Remove(textBoxNum2.Text.Length - 1, 1);
                    textBoxNum2.Focus();
                    textBoxNum2.SelectionStart = textBoxNum2.Text.Length;
                }
                catch (Exception)
                {
                    textBoxNum2.Text = "";
                }
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
                case Keys.Clear: btnDeleteLastDigit.PerformClick(); break;
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
            if (textBoxResult.Text != "" && lblNum2.Text != "")
            {
                lblAction.Text = $"Sqrt({textBoxResult.Text})";
                textBoxResult.Text = Math.Sqrt(double.Parse(textBoxResult.Text)).ToString();
                textBoxNum1.Text = textBoxResult.Text;
            }
            else if (textBoxNum2.Text != "")
            {
                lblNum2.Text = $"Sqrt({textBoxNum2.Text})";
                textBoxNum2.Text = Math.Sqrt(double.Parse(textBoxNum2.Text)).ToString();
            }
            else if (textBoxNum1.Text != "")
            {
                lblNum1.Text = $"Sqrt({textBoxNum1.Text})";
                textBoxNum1.Text = Math.Sqrt(double.Parse(textBoxNum1.Text)).ToString();
            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "" && lblNum2.Text != "")
            {
                lblAction.Text = $"Negate({textBoxResult.Text})";
                textBoxResult.Text = (double.Parse(textBoxResult.Text)*(-1)).ToString();
                textBoxNum1.Text = textBoxResult.Text;
            }
            else if (textBoxNum2.Text != "")
            {
                lblNum2.Text = $"Negate({textBoxNum2.Text})";
                textBoxNum2.Text = (double.Parse(textBoxNum2.Text) * (-1)).ToString();
            }
            else if (textBoxNum1.Text != "")
            {
                lblNum1.Text = $"Negate({textBoxNum1.Text})";
                textBoxNum1.Text = (double.Parse(textBoxNum1.Text) * (-1)).ToString();
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "" && lblNum2.Text != "")
            {
                lblAction.Text = $"Reciprocal({textBoxResult.Text})";
                textBoxResult.Text = (1 / double.Parse(textBoxResult.Text)).ToString();
                textBoxNum1.Text = textBoxResult.Text;
            }
            else if (textBoxNum2.Text != "")
            {
                lblNum2.Text = $"Reciprocal({textBoxNum2.Text})";
                textBoxNum2.Text = (1 / double.Parse(textBoxNum2.Text)).ToString();
            }
            else if (textBoxNum1.Text != "")
            {
                lblNum1.Text = $"Reciprocal({textBoxNum1.Text})";
                textBoxNum1.Text = (1 / double.Parse(textBoxNum1.Text)).ToString();
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
                    textBoxNum1.Text = textBoxNum1.Text.Remove(textBoxNum1.Text.Length - 1, 1);
                }
                else
                {
                    textBoxNum2.Text = textBoxNum2.Text.Remove(textBoxNum2.Text.Length - 1, 1);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                PreserveSelectedTextBoxSelection();
            }
            
        }
    }
}