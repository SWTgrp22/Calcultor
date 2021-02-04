using System;
using System.Collections.Generic;
using System.Text;

namespace Calcultor
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double a, double b)
        {
            if (b != 0) 
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Invalid number. Værdien b skal være forskellig fra 0");
            }

        }
    }
}
