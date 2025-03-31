using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A12Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] array) {
            for (int i = array.Length - 1; i >= 0; i--) {
                for (int j = 0; j < i; j++) {
                    if (array[j] > array[j + 1]) { 
                        int temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
