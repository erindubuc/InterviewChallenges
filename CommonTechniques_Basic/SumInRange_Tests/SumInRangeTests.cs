using NUnit.Framework;
using SumInRange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInRange_Tests
{
    [TestFixture]
    public class SumInRangeTests
    {
        SumInRangeTechnique range = new SumInRangeTechnique();

        public int[] nums;
        public int[][] queries;

        
        [Test]
        public void IfLengthOfNumsAndQueriesIsOne_NumIsZeroOrGreater_ReturnNum()
        {
            nums = new int[1] { 5 };
            queries = new int[1][] {
                new int[] { 0, 0 }
            };

            var expected = 5;
            var actual = range.FindSumInRange(nums, queries);

            Assert.AreEqual(expected, actual);
        }
        

    }
}
