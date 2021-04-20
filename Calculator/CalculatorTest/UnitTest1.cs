using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            var result = Calculators.Add(1, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Subtract()
        {
            var result = Calculators.Subtract(2, 1);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Multiply()
        {
            var result = Calculators.Multiply(1, 2);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Divide()
        {
            var result = Calculators.Divide(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}