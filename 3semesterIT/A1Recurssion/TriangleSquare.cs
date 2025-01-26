using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class TriangleSquare
    {
        public int numberOfSquaresInTriangle(int sideLength) {
            if (sideLength == 1) {
                return 1;
            }
            return sideLength + numberOfSquaresInTriangle(sideLength - 1);
        }
    }
}
