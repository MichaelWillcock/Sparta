using NUnit.Framework;
using CalculatorLib;
using System;

namespace DivisionEdgeCaseTest
{
    public class Tests
    {
        [TestCase(7, 2, 3)]
        public void DivideOddNumber(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestCase(1, 0)]
        //results in failure as it should
        public void DivideByZero(int x, int y)
        {
            
            Assert.Throws<DivideByZeroException>(() => StaticCalculatorTest.Divide(x, y));
        }
        [TestCase(10, -2, -5)]
        public void DivideNegativeAndPositive(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestCase(-10, -2, 5)]
        public void DivideNegativeByNegative(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}