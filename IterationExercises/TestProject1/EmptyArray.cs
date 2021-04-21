using NUnit.Framework;
using IterationLib;
using System;

namespace IterationTests
{
    public class IterationTests
    {
        /**  Implement the static methods in IterationLib.Highest class so that they
         * pass the following tests.  Each method should use a different type of loop as indicated:
         * while, for, foreach and do while.
         * 
         * Add more tests for each method.  What happens when the array is empty?
         * When the array contains only negative numbers?  When all the array elements are the same?
         * 
         * You will find one of the loops will not not be suitable in all cases.  Which is it? 
         * You don't need to find a devious way to make it pass - just note that it is not a suitable for this problem.
         **/


        [Test]
        public void HighestWhileLoopTest()
        {
            int[] nums = {};
            Assert.Throws<Exception>(() => Highest.HighestWhileLoop(nums));
        }

        [Test]
        public void HighestForLoopTest()
        {
            int[] nums = {};
            Assert.Throws<Exception>(() => Highest.HighestForLoop(nums));
        }

        [Test]
        public void HighestForEachLoopTest()
        {
            int[] nums = {};
            Assert.Throws<Exception>(() => Highest.HighestForEachLoop(nums));
        }

        [Test]
        public void HighestDoWhileLoopTest()
        {
            int[] nums = {};
            Assert.Throws<Exception>(() => Highest.HighestDoWhileLoop(nums));
        }
    }
}