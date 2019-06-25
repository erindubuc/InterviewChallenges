using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddDigits_SeeIfLucky;

namespace AddDigits_SeeIfLuckyTests
{
    [TestFixture]
    public class LuckyNumberTests
    {
        [Test]
        public void IfNumberIsTwoDigits_Return2()
        {
            int num = 34;

            var expected = 2;
            var actual = LuckyNumber.GetNumberOfDigits(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumberIsThreeDigits_Return3()
        {
            int num = 345;

            var expected = 3;
            var actual = LuckyNumber.GetNumberOfDigits(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumIsTwoDigits_CheckIfTheyAreEqual_Equal_ReturnTrue()
        {
            int num = 33;

            var expected = true;
            var actual = LuckyNumber.IsThisNumberLucky(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumIsTwoDigits_CheckIfTheyAreEqual_NotEqual_ReturnFalse()
        {
            int num = 34;

            var expected = false;
            var actual = LuckyNumber.IsThisNumberLucky(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumIsFourDigits_CheckIfTheirSumIsEqual_NotEqual_ReturnFalse()
        {
            int num = 3435;

            var expected = false;
            var actual = LuckyNumber.IsThisNumberLucky(num);

            Assert.AreEqual(expected, actual);
        }

    }
}
