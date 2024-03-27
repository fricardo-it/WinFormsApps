using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsFinalProject
{
    internal class Calculator
    {
        //private fields
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;

        //properties
        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }
        public decimal Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }
        public decimal Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }
        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        //Methods
        public decimal Add()
        {
            currentValue = operand1 + operand2;
            return currentValue;
        }

        public decimal Sub()
        {
            currentValue = operand1 - operand2;
            return currentValue;
        }

        public decimal Mul()
        {
            currentValue = operand1 * operand2;
            return currentValue;
        }

        public decimal Div()
        {
            currentValue = Math.Round(operand1 / operand2, 16);
            return currentValue;
        }

        public void Equals()
        {
            switch (Op)
            {
                case "+":
                    {
                        Add();
                        break;
                    }
                case "-":
                    {
                        Sub();
                        break;
                    }

                case "*":
                    {
                        Mul();
                        break;
                    }

                case "/":
                    {
                        Div();
                        break;
                    }
            }
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }
    }
}

