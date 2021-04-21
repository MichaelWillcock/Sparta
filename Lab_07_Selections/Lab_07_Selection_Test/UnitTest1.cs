using NUnit.Framework;
using Selection;
using System;


namespace Selection_Tests
{
    public class Tests
    {
        [Test]
        public void MarkOver40AndPasses()
        {
            var actual = Program.PassFail(40);
            Assert.AreEqual("Pass", actual);
        }
        [Test]
        public void MarkUnder40AndFails()
        {
            var actual = Program.PassFail(39);
            Assert.AreEqual("Fail", actual);
        }
        [TestCase(75, "Pass with Distinction")]
        [TestCase(90, "Pass with Distinction")]
        public void Mark75AndOverPassesWithDisctinction(int mark, string expectedGrade)
        {
            var result = Program.Grade(mark);
            Assert.AreEqual(expectedGrade, result);
        }
        [TestCase(63, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        public void MarkBetween60And74PassesWithMerit(int mark, string expectedGrade)
        {
            var result = Program.Grade(mark);
            Assert.AreEqual(expectedGrade, result);
        }
        [TestCase(-1)]
        [TestCase(101)]
        public void NegativeMark(int mark, string expectedGrade)
        {
            Assert.Throws<Exception>(() => Program.Grade(mark));
        }

        [TestCase(40, "Pass")]
        [TestCase(60, "Pass")]
        [TestCase(35, "Fail")]
        public void PassedTest(int mark, string expected)
        {
            var result = Program.PassFailTernary(mark);
            Assert.AreEqual(result, expected);
        }
    }
}