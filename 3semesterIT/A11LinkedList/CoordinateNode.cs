using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A11LinkedList
{
    public class CoordinateNode
    {
        public CoordinateNode next;
        public CoordinateNode previous;
        public Coordinate coordinate;
        public Coordinate[] path;

        public CoordinateNode(Coordinate coordinate, CoordinateNode next, CoordinateNode previous = null!) {         
            this.coordinate = coordinate;
            this.next = next;
            this.previous = previous;
            path = new Coordinate[] { coordinate };
        }
        
    }
}
