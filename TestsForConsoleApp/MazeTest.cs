using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11LinkedList;

namespace TestsForConsoleApp
{
    [TestClass]
    public class MazeTest
    {
        [TestMethod]
        public void testInsertFirst()
        {
            DoubleLinkedMazeList doubleList = new();
            LinkedMazeList linkedList = new();

            Coordinate c0 = new Coordinate(0, 0);
            Coordinate c1 = new Coordinate(1, 1);
            Coordinate c2 = new Coordinate(2, 2);

            linkedList.insertFirst(c0);
            linkedList.insertFirst(c1);
            linkedList.insertFirst(c2);

            Assert.AreEqual(0, linkedList.first.next.next.coordinate.x);
            Assert.AreEqual(2, linkedList.first.coordinate.y);

            doubleList.insertFirst(c0);
            doubleList.insertFirst(c1);
            doubleList.insertFirst(c2);

            Assert.AreEqual(0, doubleList.first.next.next.coordinate.x);
            Assert.AreEqual(2, doubleList.first.coordinate.x);
            Assert.AreEqual(0, doubleList.last.coordinate.x);
        }

        [TestMethod]
        public void testInsertLast() {
            DoubleLinkedMazeList doubleList = new();

            Coordinate c0 = new Coordinate(0, 0);
            Coordinate c1 = new Coordinate(1, 1);
            Coordinate c2 = new Coordinate(2, 2);

            doubleList.insertLast(c0);
            doubleList.insertLast(c1);
            doubleList.insertLast(c2);

            Assert.AreEqual(2, doubleList.first.next.next.coordinate.x);
            Assert.AreEqual(0, doubleList.first.coordinate.x);
            Assert.AreEqual(2, doubleList.last.coordinate.x);
        }

        [TestMethod]
        public void testRemoveFirst() {

            DoubleLinkedMazeList doubleList = new();
            LinkedMazeList linkedList = new();

            Coordinate c0 = new Coordinate(0, 0);
            Coordinate c1 = new Coordinate(1, 1);
            Coordinate c2 = new Coordinate(2, 2);

            linkedList.insertFirst(c0);
            linkedList.insertFirst(c1);
            linkedList.insertFirst(c2);
            
            linkedList.removeFirst();

            Assert.AreEqual(1, linkedList.first.coordinate.x);

            linkedList.removeFirst();
            linkedList.removeFirst();

            Assert.AreEqual(null, linkedList.first);

            doubleList.insertFirst(c0);
            doubleList.insertFirst(c1);
            doubleList.insertFirst(c2);

            Assert.AreEqual(0, doubleList.first.next.next.coordinate.x);
            Assert.AreEqual(2, doubleList.first.coordinate.x);
            Assert.AreEqual(0, doubleList.last.coordinate.x);

            doubleList.removeFirst();

            Assert.AreEqual(1, doubleList.first.coordinate.x);

            doubleList.removeFirst();
            doubleList.removeFirst();

            Assert.AreEqual(null, doubleList.first);
            Assert.AreEqual(null, doubleList.last);
        }

        [TestMethod]
        public void TestInsertSorted() { 
        
        
        }
    }
}
