using NUnit.Framework;
using Calculator;

namespace DivisionEdgeCaseTest
{
    public class Tests
    {
        [TestCase(7, 2, 3)]
        public void DivideOddNumber(int x, int y, int expected)
        {
            var result = Calculators.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestCase(7, 0, 0)]
        //results in failure as it should
        public void DivideByZero(int x, int y, int expected)
        {
            var result = Calculators.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestCase(10, -2, -5)]
        public void DivideNegativeAndPositive(int x, int y, int expected)
        {
            var result = Calculators.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestCase(-10, -2, 5)]
        public void DivideNegativeByNegative(int x, int y, int expected)
        {
            var result = Calculators.Divide(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}