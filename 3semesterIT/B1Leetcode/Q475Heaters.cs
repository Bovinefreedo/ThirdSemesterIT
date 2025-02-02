using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q475Heaters
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            int result = 0;
            Array.Sort(houses);
            Array.Sort(heaters);
            int j = 0;
            int i = 0;
            if (heaters.Length > 1)
            {
                while (i < houses.Length)
                {
                    int distJ = Math.Abs(houses[i] - heaters[j]);
                    int distNext = Math.Abs(houses[i] - heaters[j + 1]);
                    if (distJ < distNext)
                    {
                        if (distJ > result)
                            result = distJ;
                        i++;
                    }
                    else
                    {
                        j++;
                        if (j == heaters.Length - 1)
                            break;
                    }
                }
            }
            while (i < houses.Length)
            {
                int distJ = Math.Abs(houses[i] - heaters[j]);
                if (distJ > result)
                    result = distJ;
                i++;

            }
            return result;
        }
    }
}