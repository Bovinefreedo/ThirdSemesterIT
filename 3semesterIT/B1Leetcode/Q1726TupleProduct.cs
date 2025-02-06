using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q1726TupleProduct
    {
        public static int TupleSameProduct(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> productSeen = new Dictionary<int, int>();

            for (int i = 0; i<nums.Length; i++)
            {
                for (int j = i+1; j<nums.Length; j++)
                {
                    int product = nums[i]*nums[j];
                    if (productSeen.ContainsKey(product))
                    {
                        productSeen[product]++;
                    }
                    else {
                        productSeen[product]=1;
                    }
                }
            }
            foreach (var seen in productSeen)
            {
                if (seen.Value > 1)
                {
                    result += (seen.Value*(seen.Value-1)/2)*8;
                }
            }
            return result;
        }
    }
}
