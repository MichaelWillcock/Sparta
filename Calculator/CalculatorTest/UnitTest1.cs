using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        [TestCase(1, 2, 3)]
        public void Setup()
        {
        }

        [Test]
        public void Test1(int num1, int num2, int expected)
        {
            var result = Calculator.Add(num1, num2);
        }
    }
}