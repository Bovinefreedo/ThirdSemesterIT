using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11UserLinkedList;

namespace ThirdSemesterIT.A11LinkedList
{
    public class DoubleLinkedMazeList
    {

        public CoordinateNode first { get; set; } = null!;
        public CoordinateNode last { get; set; } = null!;

        public void addFirst(Coordinate coordinate)
        {
            CoordinateNode newNode = new CoordinateNode(coordinate, first, null!);
            if (first != null)
            {
                first.previous = newNode;
            }
            else
            {
                last = newNode;
            }
            first = newNode;
        }

        public void addLast(Coordinate coordinate)
        {
            CoordinateNode newNode = new CoordinateNode(coordinate, null!, last);
            if (last != null)
            {
                last.next = newNode;
            }
            else
            {
                first = newNode;
            }
            last = newNode;
        }

        public Coordinate? removeFirst()
        {
            if (first == null)
            {
                return null;
            }
            else if (first.next == null)
            {
                Coordinate coordinate = first.coordinate;
                first = null!;
                last = null!;
                return coordinate;
            }
            else
            {
                Coordinate coordinate = first.coordinate;
                first.next.previous = null!;
                first = first.next;
                return coordinate;
            }
        }

        public Coordinate? removeLast()
        {
            if (last == null)
            {
                return null;
            }
            else if (last.previous == null)
            {
                Coordinate coordinate = last.coordinate;
                first = null!;
                last = null!;
                return coordinate;
            }
            else
            {
                Coordinate coordinate = last.coordinate;
                first.previous.next = null!;
                last = last.previous;
                return coordinate;
            }
        }
    }
}
