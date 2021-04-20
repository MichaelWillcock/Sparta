using NUnit.Framework;
using Calculator;

namespace AdditionEdgeCaseTest
{
    public class Tests
    {
        [Test]
        public void AddPositiveToNegative()
        {
            var result = Calculators.Add(-10, 10);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddNegativeToNegative()
        {
            var result = Calculators.Add(-10, -10);
            Assert.AreEqual(-20, result);
        }
        [Test]
        public void ExceedingMaxIntValue()
        {
            var result = Calculators.Add(2147483647, 1);
            Assert.AreEqual(-2147483648, result);
        }
    }
}