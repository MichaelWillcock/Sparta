using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTest
{
    public class Tests
    {
        [Test]
        public void Add()
        {
            var result = StaticCalculatorTest.Add(1, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Subtract()
        {
            var result = StaticCalculatorTest.Subtract(2, 1);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Multiply()
        {
            var result = StaticCalculatorTest.Multiply(1, 2);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Divide()
        {
            var result = StaticCalculatorTest.Divide(2, 2);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Modulus()
        {
            var result = StaticCalculatorTest.Modulus(10, 3);
            Assert.AreEqual(1, result);
        }
    }
}