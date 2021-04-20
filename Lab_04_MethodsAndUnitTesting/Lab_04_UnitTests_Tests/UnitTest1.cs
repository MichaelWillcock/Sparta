using NUnit.Framework;
using Lab_04_MethodsAndUnitTesting;

namespace Lab_04_UnitTests_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var result = Methods.TripleCalc(a, b, c, out int sum);
            Assert.Equals(result, sum);
        }
    }
}