using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /*  You are planning to rob houses on a specific street, and you 
     *  know that every house on the street has a certain amount of 
     *  money hidden. The only thing stopping you from robbing all of 
     *  them in one night is that adjacent houses on the street have 
     *  a connected security system. The system will automatically trigger 
     *  an alarm if two adjacent houses are broken into on the same night.

        Given a list of non-negative integers nums representing the amount 
        of money hidden in each house, determine the maximum amount of money 
        you can rob in one night without triggering an alarm.

        Example:
        For nums = [1, 1, 1], the output should be
        houseRobber(nums) = 2.

        The optimal way to get the most money in one night is to rob the first and the third houses for a total of 2.

        An array representing the amount of money that each house on the street has.

        Guaranteed constraints:
        0 ≤ nums.length ≤ 100,
        0 ≤ nums[i] ≤ 500.
    */
    public static class HouseRobber
    {
        public static int MaxAmountOfMoneyFromRobbingHouses(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            // Create new array to hold max values
            int[] maxAmount = new int[nums.Length];

            // Put 0 as first value in maxAmount so either the first or second index of nums can be added to it
            maxAmount[0] = 0;

            // Compare first and second house, Choose which house to take from and make FIRST max amount 
            maxAmount[1] = Math.Max(nums[0], nums[1]);

            // Begin checking third house
            for (int indexOfRemainingHouses = 2; indexOfRemainingHouses < nums.Length; indexOfRemainingHouses++)
            {
                // Next num in maxAmount will be the max from either nums[2] + maxAmount[0] OR maxAmount[1]
                maxAmount[indexOfRemainingHouses] = Math.Max(nums[indexOfRemainingHouses] + maxAmount[indexOfRemainingHouses - 2], maxAmount[indexOfRemainingHouses - 1]);
            }
            return maxAmount[maxAmount.Length - 1];
        }
    }
}
