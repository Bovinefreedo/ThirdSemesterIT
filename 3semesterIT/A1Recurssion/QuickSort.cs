using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public  class QuickSort
    {
        public static List<int> quickSort(List<int> nums)
        {
            if (nums.Count <= 1)
            {
                return nums;
            }
            else
            {
                int pivot = nums[0];
                List<int> smaller = new List<int>();
                List<int> bigger = new List<int>();
                List<int> sameNumber = new() { pivot };
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] < pivot)
                    {
                        smaller.Add(nums[i]);
                    }
                    else if (nums[i] > pivot)
                    {
                        bigger.Add(nums[i]);
                    }
                    else
                    {
                        sameNumber.Add(nums[i]);
                    }
                }
                return quickSort(smaller).Concat(sameNumber).Concat(quickSort(bigger)).ToList();
            }

        }
    }
}
