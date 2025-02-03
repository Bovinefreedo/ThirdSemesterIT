using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q3105IncreseDecrease
    {
        public static int LongestMonotonicSubarray(int[] nums)
        {
            if (nums.Length == 1) { return 1; }
            int longestSoFar = 0;
            int currentStreak = 1;
            bool increasing = true;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    if (currentStreak > longestSoFar)
                    {
                        longestSoFar = currentStreak;
                    }
                    currentStreak = 1;
                }
                else if ((nums[i] < nums[i + 1]) == increasing)
                {
                    currentStreak++;
                }
                else
                {
                    if (currentStreak > longestSoFar)
                    {
                        longestSoFar = currentStreak;
                    }
                    currentStreak = 2;
                    increasing = !increasing;
                }
            }
            return longestSoFar>currentStreak ? longestSoFar : currentStreak;
        }
    }
}
