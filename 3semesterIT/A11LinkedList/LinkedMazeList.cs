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
        private CoordinateNode head = null!;

        public void push(CoordinateNode node)
        {
            if (head != null)
            {
                node.next = head;
            }
            head = node;
        }

        public Coordinate pop()
        {
            Coordinate coordinate = head.coordinate;
            head = head.next;
            return coordinate;
        }

        public void insertSorted(Coordinate coordinate)
        {
            if (head == null)
            {
                head = new CoordinateNode(coordinate, null!);
            }
            CoordinateNode currentNode = head;
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
                        head = newNode;
                    }
                    return;
                }
            }
        }
    }
}
