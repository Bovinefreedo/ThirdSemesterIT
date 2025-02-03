using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class RevereseString
    {
        public static string reverse(string s)
        {
            if (s.Length == 1)
                return s;
            return s.Substring(s.Length - 1, 1) + reverse(s.Remove(s.Length - 1));
        }
    }
}
