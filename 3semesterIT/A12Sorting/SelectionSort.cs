using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A12Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                int min = int.MaxValue;
                int minIndex = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min) {
                        minIndex = j; 
                        min = array[j];
                    }
                }
                array[minIndex] = array[i];
                array[i] = min;
            }
        }
    }
}
