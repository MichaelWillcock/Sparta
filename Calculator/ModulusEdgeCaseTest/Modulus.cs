using NUnit.Framework;
using CalculatorLib;

namespace ModulusEdgeCaseTest
{
    public class Tests
    {
        [Test]
        public void NegativeModulus()
        {
            var result = StaticCalculatorTest.Modulus(-16, 3);
            Assert.AreEqual(-1, result);
        }
    }
}