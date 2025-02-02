using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q3151SpecialArrayI
    {
        public static bool IsArraySpecial(int[] nums)
        {
            bool result = true;
            bool last = nums[0] % 2 == 0;
            for(int i = 1; i<nums.Length; i++) {
                if (last == (nums[i] % 2 == 0)) { 
                    result = false; break;
                }
                last = !last;
            }
            return result;
        }
    }
}
