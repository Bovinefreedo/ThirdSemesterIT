using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11UserLinkedList;

namespace ThirdSemesterIT.A11LinkedList
{
    class ListNode
    {
        public ListNode(User data, ListNode next)
        {
            this.Data = data;
            this.Next = next;
        }
        public User Data;
        public ListNode? Next;
    }
}
