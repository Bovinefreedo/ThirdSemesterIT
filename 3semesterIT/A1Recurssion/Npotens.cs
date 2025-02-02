using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class Npotens
    {
        public int NPotens(int p, int n)
        {
            if (p == 0)
                return 1;
            return NPotens(p - 1, n) * n;
        }
    }
}
