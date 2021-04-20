using NUnit.Framework;
using CalculatorLib;

namespace SubtractionEdgeCaseTest
{
    public class Tests
    {
        [Test]
        public void SubtractPositiveToNegative()
        {
            var result = StaticCalculatorTest.Subtract(-10, 10);
            Assert.AreEqual(-20, result);
        }
        [Test]
        public void SubtractNegativeToPositive()
        {
            var result = StaticCalculatorTest.Subtract(10, -10);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void ExceedingMinIntValue()
        {
            var result = StaticCalculatorTest.Subtract(-2147483648, 1);
            Assert.AreEqual(2147483647, result);
        }
    }
}