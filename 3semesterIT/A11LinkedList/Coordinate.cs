using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A11LinkedList
{
    public class Coordinate
    {
        public int x;
        public int y;
        public float distance;

        public Coordinate(int x, int y, float distance = 0)
        {
            this.x = x;
            this.y = y;
            this.distance = distance;
        }
    }
}
