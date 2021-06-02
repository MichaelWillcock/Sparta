using NUnit.Framework;
using FizzBuzzApp;

namespace FizzBuzzTest
{
    public class FizzBuzzShould
    {

        [Test]
        public void GivenOne_ReturnOneString()
        {
            Assert.That(Program.Fizzbuzz(1), Does.Contain("1"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void GivenANumberReturnItsString(int input, string expected)
        {
            Assert.That(Program.Fizzbuzz(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenThree_Return_Fizz()
        {
            Assert.That(Program.Fizzbuzz(3), Is.EqualTo("Fizz"));
        }

        [TestCase(9)]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        {
            Assert.That(Program.Fizzbuzz(input), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GivenFive_Return_Buzz()
        {
            Assert.That(Program.Fizzbuzz(5), Is.EqualTo("Buzz"));
        }

        [TestCase(25)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.Fizzbuzz(input), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GivenFifteen_Return_FizzBuzz()
        {
            Assert.That(Program.Fizzbuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(45)]
        public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        {
            Assert.That(Program.Fizzbuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}