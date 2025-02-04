using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q5LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            string longestSoFar = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int distanceFromI = 1;
                while (true)
                {
                    if (i - distanceFromI >= 0 && i + distanceFromI < s.Length && s[i - distanceFromI] == s[i + distanceFromI])
                    {
                        distanceFromI++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (longestSoFar.Length < distanceFromI * 2 - 1)
                {
                    longestSoFar = s.Substring(i - distanceFromI+1, distanceFromI * 2 - 1);
                }
                if (i + 1 < s.Length && s[i] == s[i+1])
                {
                    distanceFromI = 1;
                    while (true)
                    {
                        if (i - distanceFromI >= 0 && i + distanceFromI + 1 < s.Length && s[i - distanceFromI] == s[i + distanceFromI+1])
                        {
                            distanceFromI++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (longestSoFar.Length < distanceFromI * 2)
                    {
                        longestSoFar = s.Substring(i - distanceFromI+1, distanceFromI * 2);
                    }
                }
            }

            return longestSoFar;
        }
    }
}
