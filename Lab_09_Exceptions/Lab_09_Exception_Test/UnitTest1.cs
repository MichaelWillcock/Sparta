using NUnit.Framework;
using Lab_09_Exceptions;
using System;

namespace Lab_09_Exception_Test
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(4)]
        public void Test1(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => Program.AddBeatle(pos, "George"));
            Assert.AreEqual($"The beatles do not have the position {pos}", ex.Message, "Exception message not correct");
        }
    }
}