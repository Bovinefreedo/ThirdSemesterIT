using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{
    public class FunctionalQuickSort
    {
        public static Func<int[], int[]> quickSortFuctional = arg =>
            arg.Length <= 1 ? arg:
            quickSortFuctional(arg.Where(x => x < arg[0]).ToArray())
            .Concat(arg.Where(x => x == arg[0]))
            .Concat(quickSortFuctional(arg.Where(x => x > arg[0]).ToArray()))
            .ToArray();
    }
}
