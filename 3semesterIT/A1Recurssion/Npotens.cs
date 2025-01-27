using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class Npotens
    {
        public int NPotens(int potens, int n)
        {
            if (potens == 0)
                return 1;
            return NPotens(potens - 1, n) * n;
        }
    }
}
