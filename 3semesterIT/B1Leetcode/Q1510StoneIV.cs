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
            bool[] resultArray = new bool[n+1];

            for (int i = 0; i < n; i++) {
                bool canWin = false;
                for (int j = 1; j <= (int)Math.Sqrt(i+1); j++) {
                    if (!resultArray[i +1 - (int)Math.Pow(j, 2)]) {
                        canWin = true; 
                        break;
                    }
                }
                canWin = (int)Math.Pow(Math.Sqrt(i+1), 2) == i + 1;
                resultArray[i] = canWin; 
            }
            return resultArray[n-1];
        }
    }
}
