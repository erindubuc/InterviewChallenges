using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class ClimbingStairs
    {
        /*  You are climbing a staircase that has n steps. 
         *  You can take the steps either 1 or 2 at a time. 
         *  Calculate how many distinct ways you can climb to the top of the staircase.

            Example
            For n = 1, the output should be
            climbingStairs(n) = 1;

            For n = 2, the output should be
            climbingStairs(n) = 2.

            You can either climb 2 steps at once or climb 1 step two times.
        */

        public static int HowManyDistinctWaysToClimbStairs(int numberOfStairs)
        {
            if (numberOfStairs == 1)
                return numberOfStairs;
            if (numberOfStairs == 2)
                return numberOfStairs;

            return HowManyDistinctWaysToClimbStairs(numberOfStairs - 2) + HowManyDistinctWaysToClimbStairs(numberOfStairs - 1);
        }
    }
}
