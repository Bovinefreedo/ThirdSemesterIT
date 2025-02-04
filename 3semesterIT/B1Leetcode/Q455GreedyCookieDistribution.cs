using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q455GreedyCookieDistribution
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            //I know what I did here and it is not good!
            int satisfiedChildren = 0;
            Array.Sort(g);
            Array.Sort(s);
            int greedyIndex = 0;
            int cookieSizeIndex = 0;
            foreach (int item in g)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cookies");
            foreach (int item in s) { 
                Console.WriteLine(item);
            }

            while (greedyIndex < g.Length && cookieSizeIndex < s.Length) {
                if (g[greedyIndex] <= s[cookieSizeIndex])
                {
                    satisfiedChildren++;
                    greedyIndex++;
                    cookieSizeIndex++;
                }
                else
                {
                    cookieSizeIndex++;
                }
            }

            return satisfiedChildren;
        }
    }
}
