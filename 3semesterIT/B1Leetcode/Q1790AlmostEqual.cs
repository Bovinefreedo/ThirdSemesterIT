using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q1790AlmostEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            bool result = true;
            char s1Char = 'a';
            char s2Char = 'a';
            bool oneDifference = false;

            for (int i = 0; i < s1.Length; i++) {
                if (s1[i] != s2[i])
                {
                    if (oneDifference && result)
                    {
                        return false;
                    }
                    else if (oneDifference)
                    {
                        if (s1[i] == s2Char && s1Char == s2[i])
                            result = true;
                        else
                            return false;
                    }
                    else {
                        oneDifference = true;
                        result = false;
                        s1Char = s1[i];
                        s2Char = s2[i];
                    }
                }
            }
            return result;
        }
    }
}
