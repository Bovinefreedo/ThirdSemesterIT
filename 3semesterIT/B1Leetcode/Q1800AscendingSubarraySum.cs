using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q1800AscendingSubarraySum
    {
        public static int MaxAscendingSum(int[] nums)
        {
            int maxSoFar = nums[0];
            int currentStreak = nums[0];
            for (int i = 0; i < nums.Length - 1; i++) {
                if (nums[i] < nums[i + 1])
                {
                    currentStreak += nums[i + 1];
                }
                else {
                    if (currentStreak > maxSoFar) { 
                        maxSoFar = currentStreak;
                    }
                    currentStreak = nums[i + 1];
                }
            }
            return maxSoFar > currentStreak ? maxSoFar : currentStreak;
        }
    }
}
