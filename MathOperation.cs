using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    class MathOperation
    {
        public static double Add(double number1, double number2)
        {
            return (number1 + number2);
        }

        public static double Substract(double number1, double number2)
        {
            return (number1 - number2);
        }

        public static double Multiply(double number1, double number2)
        {
            return (number1 * number2);
        }
        public static double Divide(double number1, double number2)
        {
            return (number1 / number2);
        }
    }
}
