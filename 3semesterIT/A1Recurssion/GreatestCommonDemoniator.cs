using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class GreatestCommonDemoniator
    {
        public static int gcd(int a, int b)
        {
            if (b <= a && a % b == 0)
            {
                return b;
            }
            else if (a < b)
            {
                return gcd(b, a);
            }
            else
            {
                return gcd(b, a % b);
            }
        }
    }
}
