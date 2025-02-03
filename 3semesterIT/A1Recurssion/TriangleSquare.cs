using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class TriangleSquare
    {
        public static int numberOfSquaresInTriangle(int sideLength)
        {
            if (sideLength == 1)
            {
                return 1;
            }
            return sideLength + numberOfSquaresInTriangle(sideLength - 1);
        }

        public int usingForloop(int sideLength)
        {
            int result = 0;
            for (int i = sideLength; i > 0; i--)
            {
                result += i;
            }
            return result;
        }
    }
}
