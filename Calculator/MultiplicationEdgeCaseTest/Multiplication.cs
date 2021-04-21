using NUnit.Framework;
using CalculatorLib;
using System;

namespace MultiplicationEdgeCaseTest
{
    public class Tests
    {
        [TestCase(5, 5, 25)]
        public void SquareMultiply(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Multiply(x, y);

            Assert.AreEqual(expected, result);
        }
        [TestCase(-5, 5, -25)]
        public void PositiveToNegativeMultiply(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Multiply(x, y);

            Assert.AreEqual(expected, result);
        }
        [TestCase(-5, -5, 25)]
        public void NegativeToNegativeMultiply(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Multiply(x, y);

            Assert.AreEqual(expected, result);
        }
        [TestCase(5, 0, 0)]
        public void ZeroCaseTest(int x, int y, int expected)
        {
            var result = StaticCalculatorTest.Multiply(x, y);

            Assert.AreEqual(expected, result);
        }
        [TestCase(2000000000, 10, 20000000000)]
        //results in failure as it should
        public void ExceedMultilpication(int x, int y, int expected)
        {
            Assert.Throws<OverflowException>(() => StaticCalculatorTest.Multiply(x, y));
        }
    }
}