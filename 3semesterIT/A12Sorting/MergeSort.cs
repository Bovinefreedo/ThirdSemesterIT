using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A12Sorting
{
    public class MergeSort
    {
        public static void Sort(int[] array) {
           array = mergeSort(array.ToList()).ToArray();
        }

        public static List<int> mergeSort(List<int> nums)
        {
            if (nums.Count == 1)
            {
                return nums;
            }
            else
            {
                List<int> listOne = mergeSort(nums.GetRange(0, nums.Count / 2));
                List<int> listTwo = mergeSort(nums.GetRange(nums.Count / 2, nums.Count - nums.Count / 2));

                return merge(listOne, listTwo);
            }
        }

        public static List<int> merge(List<int> listOne, List<int> listTwo)
        {
            List<int> result = new();
            while (listOne.Count > 0 || listTwo.Count > 0)
            {
                if (listOne.Count > 0 && listTwo.Count > 0)
                {
                    if (listOne[0] < listTwo[0])
                    {
                        result.Add(listOne[0]);
                        listOne.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(listTwo[0]);
                        listTwo.RemoveAt(0);
                    }
                }
                else if (listOne.Count > 0)
                {
                    result = result.Concat(listOne).ToList();
                    break;
                }
                else
                {
                    result = result.Concat(listTwo).ToList();
                    break;
                }
            }
            return result;
        }
    }
}
