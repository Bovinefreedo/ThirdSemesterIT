using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A10Search
{
        public class Search
    {
        /// <summary>
        /// Finder tallet i arrayet med en lineær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        public static int FindNumberLinear(int[] array, int tal) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == tal) {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Finder tallet i arrayet med en binær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        public static int FindNumberBinary(int[] array, int tal) {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high) { 
                int searchedIndex = high - (high - low) / 2;
                if (array[searchedIndex] == tal) {
                    return searchedIndex;
                }
                if (array[searchedIndex] < tal)
                {
                    low = searchedIndex +1;
                }
                else {
                    high = searchedIndex -1; 
                }
            }
            return -1;
        }

        private static int[] sortedArray { get; set; } =
            new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private static int next = 0;

        /// <summary>
        /// Indsætter et helt array. Arrayet skal være sorteret på forhånd.
        /// </summary>
        /// <param name="sortedArray">Array der skal indsættes.</param>
        /// <param name="next">Den næste ledige plads i arrayet.</param>
        public static void InitSortedArray(int[] sortedArray, int next)
        {
            Search.sortedArray = sortedArray;
            Search.next = next;
        }

        /// <summary>
        /// Indsætter et tal i et sorteret array. En kopi af arrayet returneres.
        /// Array er fortsat sorteret efter det nye tal er indsat.
        /// </summary>
        /// <param name="tal">Tallet der skal indsættes</param>
        /// <returns>En kopi af det sorterede array med det nye tal i.</returns>
        public static int[] InsertSorted(int tal) {
            // TODO: Implement!
            if (next == sortedArray.Length)
            {
                return sortedArray;
            }
            int hold = tal;
            int i = 0;
            while(true) {
                if (i == sortedArray.Length)
                {
                    break;
                }
                if (hold < sortedArray[i] || hold ==-1)
                {
                    int keep = sortedArray[i];
                    sortedArray[i] = hold;
                    hold = keep;
                }
                else {
                    if (sortedArray[i] == -1)
                        sortedArray[i] = hold;
                        break;
                }
                i++;
            }
            return sortedArray;
        }

        public void printArray(int[] array) { 
            string result = "[";
            foreach (int item in array) { 
                result += $"{item}, ";
            }
            result += "]";
            Console.WriteLine(result);


        }
    }
}
