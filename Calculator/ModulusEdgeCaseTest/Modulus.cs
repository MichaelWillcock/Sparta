using NUnit.Framework;
using Calculator;

namespace ModulusEdgeCaseTest
{
    public class Tests
    {
        [Test]
        public void NegativeModulus()
        {
            var result = Calculators.Modulus(-16, 3);
            Assert.AreEqual(-1, result);
        }
    }
}