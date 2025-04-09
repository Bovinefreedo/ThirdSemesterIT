using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A12Sorting
{
    public class QuickSort
    {
        public static void Sort(int[] array)
        {
            quickSort(array, 1, array.Length-1);
        }

        public static void quickSort(int[] array, int low, int high)
        {
            if (low < high) { 
                int pivot = Partition(array, low, high);
                quickSort(array, low, pivot - 1);
                quickSort(array, pivot + 1, high);
            }
        }

        public static int Partition(int[] array, int low, int high) {
            int pivot = array[high-1];
            int i = low -1;
            int j = low;
            while(j<high-1) {
                if (array[j] <= pivot)
                {
                    i++;
                    ArraySwap(array, j, i);
                }
                else {
                    j++;
                }
            }
            ArraySwap(array, high-1, i+1);

            return i +1;
        }

        public static void ArraySwap(int[] array, int indexA, int indexB)
        {
            int A = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = A;
        }
    }
}
