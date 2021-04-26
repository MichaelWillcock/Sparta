using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Divide(int number1, int number2)
        {
                return number1 / number2;
        }
        public static int Square(int number1)
        {
            return (int)Math.Pow(number1, 2);
        }
    }
}

