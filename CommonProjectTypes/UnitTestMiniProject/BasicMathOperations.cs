using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestMiniProject
{
    public class BasicMathOperations
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}
