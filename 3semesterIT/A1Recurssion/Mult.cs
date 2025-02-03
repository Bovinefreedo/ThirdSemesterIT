using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class Mult
    {
        public static int mult(int n, int m)
        {
            if (n == 1) return m;
            if (n == 0) return 0;
            return mult(n - 1, m) + m;
        }
    }
}
