using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q1510StoneIV
    {
        public static bool WinnerSquareGame(int n)
        {
            Dictionary<int, bool> canWin = new();
            for (int i = 1; i <= n; i++) {
                bool isWinning = false;
                int sqrtI = (int)Math.Sqrt(i);
                if ((int)Math.Pow(sqrtI, 2) == i) { 
                    canWin[i] = true;
                    continue;
                }
                for (int j = 1; j <= sqrtI; j++) {
                    if (!canWin[i-(int)Math.Pow(j,2)]) {
                        isWinning = true;
                        break;
                    }
                }
                canWin[i] = isWinning;
            }
            return canWin[n];
        }
    }
}
