using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public  class Facultet
    {
        public static int facReccursive(int n)
        {
            if (n == 0) return 1;
            return facReccursive(n - 1) * n;
        }

        public static int facLoop(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
