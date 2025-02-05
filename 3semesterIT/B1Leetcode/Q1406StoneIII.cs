using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q1406StoneIII
    {
        public string StoneGameIII(int[] stoneValue)
        {
            int[] s = stoneValue.Concat(new int[3] {0,0,0}).ToArray();
            int[] result = new int[s.Length];
            int i = stoneValue.Length-1;
            while (i >= 0) {
                int takeOne = s[i] - result[i + 1];
                int takeTwo = s[i] + s[i + 1] - result[i + 2];
                int takeThree = s[i] + s[i + 1] + s[i + 2] - result[i + 3];
                result[i] = Math.Max(Math.Max(takeOne, takeTwo),takeThree);

                i--;
            }
            return result[0] > 0 ? "Alice" : result[0] < 0 ? "Bob" : "Tie";
        }
    }
}
