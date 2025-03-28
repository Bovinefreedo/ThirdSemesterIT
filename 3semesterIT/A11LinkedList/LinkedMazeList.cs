using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11UserLinkedList;

namespace ThirdSemesterIT.A11LinkedList
{
    public class LinkedMazeList
    {
        public CoordinateNode first = null!;

        public void insertFirst(Coordinate coordinate)
        {
                first = new CoordinateNode(coordinate, first);
        }

        public Coordinate removeFirst()
        {
            Coordinate coordinate = first.coordinate;
            first = first.next;
            return coordinate;
        }

        public void insertSorted(Coordinate coordinate)
        {
            if (first == null)
            {
                first = new CoordinateNode(coordinate, null!);
            }
            CoordinateNode currentNode = first;
            CoordinateNode? previousNode = null!;
            while(true)
            {
                if (currentNode == null)
                {
                    previousNode.next = new CoordinateNode(coordinate, null!);
                    return;
                }
                else if (coordinate.distance < currentNode.coordinate.distance)
                {
                    CoordinateNode newNode = new CoordinateNode(coordinate, currentNode);
                    if (previousNode != null)
                    {
                        previousNode.next = newNode;
                    }
                    else
                    {
                        first = newNode;
                    }
                    return;
                }
            }
        }
    }
}
