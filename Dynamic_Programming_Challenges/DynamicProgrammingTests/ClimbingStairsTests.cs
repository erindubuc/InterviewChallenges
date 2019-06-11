using DynamicProgramming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingTests
{
    [TestFixture]
    public class ClimbingStairsTests
    {
        public int numberOfStairs;
        [Test]
        public void StaircaseWithOneStep_ReturnOneDistinctWay()
        {
            numberOfStairs = 1;
            int expected = 1;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithTwoSteps_ReturnTwo()
        {
            numberOfStairs = 2;
            int expected = 2;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithThreeSteps_ReturnThree()
        {
            numberOfStairs = 3;
            int expected = 3;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithFourSteps_ReturnFive()
        {
            numberOfStairs = 4;
            int expected = 5;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithFive_ReturnEight()
        {
            numberOfStairs = 5;
            int expected = 8;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithSix_ReturnThirteen()
        {
            numberOfStairs = 6;
            int expected = 13;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaircaseWithSeven_ReturnTwentyOne()
        {
            numberOfStairs = 7;
            int expected = 21;
            int actual = ClimbingStairs.HowManyDistinctWaysToClimbStairs(numberOfStairs);

            Assert.AreEqual(expected, actual);
        }
    }
}
