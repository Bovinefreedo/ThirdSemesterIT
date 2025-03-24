using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11LinkedList;
using ThirdSemesterIT.A11UserLinkedList;

namespace TestsForConsoleApp
{
    [TestClass]
    public class DoubleLinkedListTest
    {
        [TestMethod]
        public void InsertFirst() {
            DoublyLinkedList list = new();
            User kristian = new User("Kristian", 1);
            User mads = new User("Mads", 2);
            User torill = new User("Torill", 3);
            User ole = new User("Ole", 4);
            User henrik = new User("Henrik", 5);

            list.addFirst(kristian);
            list.addFirst(mads);
            list.addFirst(torill);
            list.addFirst(ole);
            list.addFirst(henrik);

            Assert.AreEqual(list.first.data, henrik);
            Assert.AreEqual(list.last.data, kristian);
        }
        [TestMethod]
        public void InsertLast() {
            DoublyLinkedList list = new();
            User kristian = new User("Kristian", 1);
            User mads = new User("Mads", 2);
            User torill = new User("Torill", 3);
            User ole = new User("Ole", 4);
            User henrik = new User("Henrik", 5);

            list.addLast(kristian);
            list.addLast(mads);
            list.addLast(torill);
            list.addLast(ole);
            list.addLast(henrik);

            Assert.AreEqual(list.first.data, kristian);
            Assert.AreEqual(list.last.data, henrik);
        }

        
    }
}
