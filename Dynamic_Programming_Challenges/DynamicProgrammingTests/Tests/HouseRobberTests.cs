using DynamicProgramming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingTests.Tests
{
    [TestFixture]
    class HouseRobberTests
    {
        public int[] nums;
         

        [Test]
        public void IfArrayIsEmpty_ReturnZero()
        {
            nums = new int[0];

            int expected = 0;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasOneNum_ReturnNum()
        {
            nums = new int[1] { 350 };

            int expected = 350;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasTwoNums_ReturnGreaterNum()
        {
            nums = new int[2] { 5, 350 };

            int expected = 350;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasThreeNums_ReturnGreatestSum()
        {
            nums = new int[3] { 5, 350, 100 };

            int expected = 350;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasFourNums_ReturnGreatestSumOfTwoNums()
        {
            nums = new int[4] { 5, 350, 100, 7 };

            int expected = 357;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasFiveNums_ReturnGreatestSumOfAlternatingNums()
        {
            nums = new int[5] { 5, 350, 100, 7, 40 };

            int expected = 390;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasFiveNums_ReturnGreatestSumOfAnyNonConsecutiveNums()
        {
            nums = new int[5] { 5, 350, 5, 7, 400 };

            int expected = 750;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfArrayHasNumsElevenNums_ReturnGreatestSumOfAnyNonConsecutiveNums()
        {
            nums = new int[11] { 5, 350, 5, 7, 400, 50, 100, 20, 30, 8, 11 };

            int expected = 891;
            int actual = HouseRobber.MaxAmountOfMoneyFromRobbingHouses(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
