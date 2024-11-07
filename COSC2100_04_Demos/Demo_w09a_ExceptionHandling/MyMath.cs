using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_w09a_ExceptionHandling
{
    public static class MyMath
    {

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Sqrt(double a)
        {
            if (a < 0)
            {
                throw new ArithmeticException("Cannot take square root of a negative number");
            }
            return Math.Sqrt(a);
        }

       
    }
}
