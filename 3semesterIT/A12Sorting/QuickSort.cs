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
            quickSort(array, 0, array.Length - 1);
        }

        public static void quickSort(int[] array, int low, int high)
        {
            int i = low + 1;
            int j = high;
            if (i > j) { return; }
            int pivot = array[low];
            while (i < j)
            {
                if (array[i] <= pivot)
                {
                    i++;
                }
                else
                {
                    while (i < j)
                    {
                        if (array[j] > pivot)
                        {
                            j--;
                        }
                        else
                        {
                            ArraySwap(array, i, j);
                            i++;
                            j--;
                            break;
                        }
                    }
                }
            }
            ArraySwap(array, low, j);
            quickSort(array, low, j - 1);
            quickSort(array, j + 1, high);
        }

        public static void ArraySwap(int[] array, int indexA, int indexB)
        {
            int A = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = A;
        }
    }
}
