using NUnit.Framework;
using Calculator;

namespace SubtractionEdgeCaseTest
{
    public class Tests
    {
        [Test]
        public void SubtractPositiveToNegative()
        {
            var result = Calculators.Subtract(-10, 10);
            Assert.AreEqual(-20, result);
        }
        [Test]
        public void SubtractNegativeToPositive()
        {
            var result = Calculators.Subtract(10, -10);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void ExceedingMinIntValue()
        {
            var result = Calculators.Subtract(-2147483648, 1);
            Assert.AreEqual(2147483647, result);
        }
    }
}