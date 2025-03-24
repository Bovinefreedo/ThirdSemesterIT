using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11UserLinkedList;

namespace ThirdSemesterIT.A11LinkedList
{
    public class DoublyLinkedList
    {
        public DoubleLinkedNode first { get; set; } = null!;
        public DoubleLinkedNode last { get; set; } = null!;

        public void addFirst(User user) {
            DoubleLinkedNode newNode = new DoubleLinkedNode(null!, first, user);
            if (first != null)
            {
                first.previous = newNode;
            }
            else { 
                first = newNode;
                last = newNode;
            }
            first = newNode;
        }

        public void addLast(User user) {
            DoubleLinkedNode newNode = new DoubleLinkedNode(last, null!, user);
            if (last != null)
            {
                last.next = newNode;
            }
            else {
                first = newNode;
                last = newNode;
            }
            last = newNode;
        }

        public void removeFirst() {
            if (first == null)
            {
                return;
            }
            else if (first.next == null)
            {
                first = null!;
                last = null!;
                return;
            }
            else
            {
                first.next.previous = null!;
                first = first.next;
                return;
            }
        }

        public void removeLast() {
            if (last == null)
            {
                return;
            }
            else if (last.previous == null)
            {
                first = null!;
                last = null!;
                return;
            }
            else { 
                first.previous.next = null!;
                last = last.previous;
                return;
            }
        }

    }
}
