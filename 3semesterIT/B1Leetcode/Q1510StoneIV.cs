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
            bool[] resultArray = new bool[n];

            for (int i = 1; i <= n; i++) {
                bool canWin = false;
                for (int j = 1; j <= (int)Math.Sqrt(i); j++) {
                    if (!resultArray[i - (int)Math.Pow(j, 2)]) {
                        Console.WriteLine($"can win on{i}");
                        canWin = true; 
                        break;
                    }
                }
                canWin = (int)Math.Pow(Math.Sqrt(i), 2) - i == 0;
                resultArray[i - 1] = canWin; 
            }
            return resultArray[n-1];
        }
    }
}
