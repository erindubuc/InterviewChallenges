using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits_SeeIfLucky
{
    public static class LuckyNumber
    {
        /*  Ticket numbers usually consist of an even number of digits. 
         *  A ticket number is considered lucky if the sum of the first 
         *  half of the digits is equal to the sum of the second half.

            Given a ticket number n, determine if it's lucky or not.
        */

        public static int GetNumberOfDigits(int num)
        {
            return num.ToString().Length;
        }

        public static bool IsThisNumberLucky(int num)
        {
            int numOfDigits = GetNumberOfDigits(num);
            int leftHalfSum = 0;
            int rightHalfSum = 0;
            string numberString = num.ToString();


            for (int digitsToAdd = 0; digitsToAdd < numOfDigits/2; digitsToAdd++)
            {
                leftHalfSum += numberString[digitsToAdd];
            }
            for (int digitsToAdd = numOfDigits / 2; digitsToAdd < numberString.Length; digitsToAdd++)
            {
                rightHalfSum += numberString[digitsToAdd];
            }
            if (leftHalfSum == rightHalfSum)
                return true;
            else
                return false;
        }

       

    }
}
