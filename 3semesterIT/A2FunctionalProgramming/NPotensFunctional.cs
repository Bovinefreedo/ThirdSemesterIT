using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{
    public class NPotensFunctional
    {
        public static Func<int, int, int> nPotens = (n, p) =>
            p == 0 ? 1 :
            n * nPotens(n, p - 1);
        
    }
}
