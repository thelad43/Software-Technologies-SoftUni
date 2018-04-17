namespace CalculatorApp.Models
{
    using System;

    public class Calculator
    {
        public double? LeftOperand { get; set; }

        public double? RightOperand { get; set; }

        public char Operator { get; set; }

        public double? Result { get; set; }

        public void CalculateResult()
        {
            switch (this.Operator)
            {
                case '+':
                    this.Result = this.LeftOperand + this.RightOperand;
                    break;

                case '-':
                    this.Result = this.LeftOperand - this.RightOperand;
                    break;

                case '*':
                    this.Result = this.LeftOperand * this.RightOperand;
                    break;

                case '/':
                    this.Result = this.LeftOperand / this.RightOperand;
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}