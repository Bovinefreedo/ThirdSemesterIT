using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q2405PartiotionString
    {
        public static int PartitionString(string s)
        {
            bool[] seen = new bool[26];
            int result = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (seen[(int)s[i] - 97])
                {
                    result++;
                    seen = new bool[26];
                    seen[(int)s[i] - 97] = true;
                }
                else
                {
                    seen[(int)s[i] - 97] = true;
                }

            }
            return result;
        }
    }
}
