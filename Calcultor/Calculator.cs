using System;
using System.Collections.Generic;
using System.Text;

namespace Calcultor
{
    public class Calculator
    {
        public double accumulator { get; private set; }
        public double Add(double a, double b)
        {
            accumulator = a + b;

            return accumulator;
        }

        public double Subtract(double a, double b)
        {
            accumulator = a - b;

            return accumulator;
        }

        public double Multiply(double a, double b)
        {
            accumulator = a * b;

            return accumulator;
        }

        public double Power(double x, double exp)
        {
            accumulator = Math.Pow(x, exp);
            return accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                accumulator = a / b;
                return accumulator;
            }
            else
            {
                accumulator = 0;
                throw new ArgumentException("Invalid number. Værdien b skal være forskellig fra 0");
            }

        }

        public void Clear()
        {
            if (accumulator != 0)
            {
                accumulator = 0;
            }

            
        }
    }
}
