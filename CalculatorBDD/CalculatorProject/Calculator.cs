using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorProject
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public int Divide()
        {
            return Num1 / Num2;
        }
        public int SumOfEvenNums(List<int> numsList)
        {
            return numsList.Where(x => x % 2 == 0).Sum();
        }
    }
}
