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
            quickSort(array, 0, array.Length-1);
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
            int pivot = array[low];
            int i = low + 1;
            for (int j = high; j > i; j--) {
                if (array[j] < pivot) { 
                    ArraySwap(array, j, i);
                    i++;
                }
            }
            if (array[i]!= pivot)
                ArraySwap(array, low, i);

            return i;
        }

        public static void ArraySwap(int[] array, int indexA, int indexB)
        {
            int A = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = A;
        }
    }
}
