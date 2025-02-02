using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{
    public class MergeSortFunctional
    {
        public static Func<int[], int[]> mergeSort = array =>
            array.Length == 1 ? array :
            merge(mergeSort(array.Where(x => x % 2 == 0).ToArray()), mergeSort(array.Where(x => x % 2 == 1).ToArray()));

        public static Func<int[], int[], int[]> merge = (x, y) => new int[0];
            
    }
}
