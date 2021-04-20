using NUnit.Framework;
using Lab_04_MethodsAndUnitTesting;

namespace Lab_04_UnitTests_Tests
{
    public class Tests
    {
        //private int _result;
        //private int _sum;
        //[SetUp]
        //public void Setup()
        //{
        //    //arrange and act
        //    _result = Methods.TripleCalc(10, 2, 4, out int sum);
        //    _sum = sum;
        //}

        [TestCase(10, 2, 4, 80)]
        [TestCase(0, -3, 7, 0)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Methods.TripleCalc(a, b, c, out int sum);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 4, 16)]
        [TestCase(0, -3, 7, 4)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            Methods.TripleCalc(a, b, c, out int sum);

            Assert.AreEqual(expected, sum);
        }
    }
}