using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{
    public class GreatestCommonDenominatorFucntional
    {
        public static Func<int, int, int> gcd = (a, b) =>
            b <= a && a % b == 0 ? b :
            a < b ? gcd(b, a) :
            gcd(b, a % b);
    }
}
