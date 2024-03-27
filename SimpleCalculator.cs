using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class SimpleCalculator : Form
    {
        private Calculator calculator;
        // variable operation --> private, because has another op in Calculator.cs
        private string op;
        bool decimalPoint = false;
        // there's the first caracter of string
        bool firstNumber = true;
        // it is the second operation
        bool secondOperand = false;

        // Data to txt file
        string dir = @".\files\";
        string file = "Calculator.txt";
        string name = "Simple Calculator";

        public SimpleCalculator()
        {
            InitializeComponent();

            // new obj type Calculator
            calculator = new Calculator();

            // initializing operation
            op = "";

            // if has decimal point, inicializing no (false)
            decimalPoint = false;

            // if first number (true)
            firstNumber = true;

            // used to keyboard press
            KeyPreview = true;
        }

        public void enableOpBtn(bool enable)
        {
            if (enable)
            {
                btnDiv.Enabled = true;
                btnMul.Enabled = true;
                btnSub.Enabled = true;
                btnSum.Enabled = true;
            }
            else
            {
                btnSum.Enabled = false;
                btnDiv.Enabled = false;
                btnMul.Enabled = false;
                btnSub.Enabled = false;
            }

        }
        // onclick for numbers buttons (0..9)
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                if (op == "" && firstNumber)
                {
                    textBox1.Text = btn.Text;
                    // now, is not first number
                    firstNumber = false;
                    // enable buttons
                    enableOpBtn(true);
                }
                else
                {
                    textBox1.Text += btn.Text;
                }

                if (secondOperand)
                {
                    // disable buttons
                    enableOpBtn(false);
                    //enable equal button
                    btnEqual.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPointClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                // if has decimal point, ignore
                if (!decimalPoint)
                {
                    if (op == "" && firstNumber)
                    {
                        textBox1.Text = "0.";
                        // now, is not first number
                        firstNumber = false;
                        // enable buttons
                        enableOpBtn(true);
                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                    // now has decimal point
                    decimalPoint = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // onclick for operations buttons (+ - * /)
        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                if (op == "")
                {
                    //op = btn.Text;
                    calculator.Op = btn.Text;
                    calculator.Operand1 = decimal.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text + "\r\n" + calculator.Op;
                    textBox1.Text = "";

                    // control if secondOperator is eneble to insert
                    secondOperand = true;

                    decimalPoint = false;
                    // disable buttons
                    enableOpBtn(false);
                    btnEqual.Enabled = false;
                }
                else
                {
                    // disable buttons
                    enableOpBtn(false);
                    //disaable equal button
                    btnEqual.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(textBox1.Text) == 0)
                {
                    MessageBox.Show("Cannot divide by zero", name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // operand2
                    calculator.Operand2 = Convert.ToDecimal(textBox1.Text);

                    // call the Equals to calculate the operaation
                    calculator.Equals();

                    // put the result into textbox1, rouding to 10 decimals 
                    textBox1.Text = Math.Round(calculator.CurrentValue, 10).ToString();
                    // show operations into textbox2
                    string txt = "";
                    txt = calculator.Operand2 + "\r\n=" + Math.Round(calculator.CurrentValue, 10) + "\r\n--------\r\n";
                    textBox2.AppendText(txt);

                    // save the operations into txt file
                    saveOnFile(calculator.Operand1, calculator.Op, calculator.Operand2);

                    // clear the operation
                    op = "";

                    // there's no number (will be the first)
                    firstNumber = true;
                    // there's no decimal point
                    decimalPoint = false;
                    // disable buttons
                    enableOpBtn(false);

                    btnEqual.Enabled = false;
                    // flag there's no second operand
                    secondOperand = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear();
            calculator.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            op = "";
            // there's no number
            firstNumber = true;
            secondOperand = false;
            decimalPoint = false;
            // read only
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            //buttons disabled
            enableOpBtn(false);

            btnEqual.Enabled = false;
        }

        private void saveOnFile(decimal printOp1, string printOp, decimal printOp2)
        {
            string path = Path.Combine(dir, file);

            string line = $"{printOp1.ToString()} {printOp} {printOp2.ToString()} = {calculator.CurrentValue}";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {
            //Clear();
            calculator.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            op = "";
            // there's no number
            firstNumber = true;
            // read only
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            //buttons disabled
            enableOpBtn(false);

            btnEqual.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "Simple Calculator";

            if (MessageBox.Show("Do you want to quit the application \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void SimpleCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //switch (e.KeyChar)
            //{
            //    case '1':
            //        {
            //            // Simulate a button click
            //            button1.PerformClick();
            //            break;
            //        }
            //    case '2':
            //        {
            //            // Simulate a button click
            //            button2.PerformClick();
            //            break;
            //        }
            //    case '3':
            //        {
            //            // Simulate a button click
            //            button3.PerformClick();
            //            break;
            //        }
            //    case '4':
            //        {
            //            // Simulate a button click
            //            button4.PerformClick();
            //            break;
            //        }
            //    case '5':
            //        {
            //            // Simulate a button click
            //            button5.PerformClick();
            //            break;
            //        }
            //    case '6':
            //        {
            //            // Simulate a button click
            //            button6.PerformClick();
            //            break;
            //        }
            //    case '7':
            //        {
            //            // Simulate a button click
            //            button7.PerformClick();
            //            break;
            //        }
            //    case '8':
            //        {
            //            // Simulate a button click
            //            button8.PerformClick();
            //            break;
            //        }
            //    case '9':
            //        {
            //            // Simulate a button click
            //            button9.PerformClick();
            //            break;
            //        }
            //    case '0':
            //        {
            //            // Simulate a button click
            //            button0.PerformClick();
            //            break;
            //        }
            //    case '.':
            //        {
            //            // Simulate a button click
            //            btnPoint.PerformClick();
            //            break;
            //        }
            //    case '+':
            //        {
            //            // Simulate a button click
            //            btnSum.PerformClick();
            //            break;
            //        }
            //    case '-':
            //        {
            //            // Simulate a button click
            //            btnSum.PerformClick();
            //            break;
            //        }
            //    case '*':
            //        {
            //            // Simulate a button click
            //            btnSum.PerformClick();
            //            break;
            //        }
            //    case '/':
            //        {
            //            // Simulate a button click
            //            btnSum.PerformClick();
            //            break;
            //        }
            //    case (char)13:
            //        {
            //            // Simulate a button click
            //            btnEqual.PerformClick();
            //            break;
            //        }
            //} 
        }
    }
}
