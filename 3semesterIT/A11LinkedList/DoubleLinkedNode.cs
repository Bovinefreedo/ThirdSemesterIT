using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11UserLinkedList;

namespace ThirdSemesterIT.A11LinkedList
{
    public class DoubleLinkedNode
    {
        public DoubleLinkedNode previous { get; set; }
        public DoubleLinkedNode next { get; set; }
        public User data { get; set; }

        public DoubleLinkedNode(DoubleLinkedNode previous, DoubleLinkedNode next, User data)
        {
            this.previous = previous;
            this.next = next;
            this.data = data;
        }
    }
}
