using System.Security;
using ThirdSemesterIT.A11LinkedList;
using ThirdSemesterIT.B1Leetcode;

namespace ThirdSemesterIT.A11UserLinkedList
{

    public class UserLinkedList
    {
        private ListNode first = null!;

        public void AddFirst(User user)
        {
            ListNode node = new ListNode(user, first);
            first = node;
        }

        public User RemoveFirst()
        {
            User removedUser = first.Data;
            first = first.Next;
            return removedUser;
        }

        public void RemoveUser(User user)
        {
            ListNode node = first;
            ListNode previous = null!;
            bool found = false;

            while (!found && node != null)
            {
                if (node.Data.Name == user.Name)
                {
                    found = true;
                    if (node == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;
                    node = node.Next;
                }
            }
        }

        public User GetFirst()
        {
            return first.Data;
        }

        public User GetLast()
        {
            ListNode currentNode = first;
            if(first == null)
            {
                return null!;
            }
            while (currentNode.Next != null) { 
                currentNode = currentNode.Next;
            }
            return currentNode.Data;
        }

        public int CountUsers()
        {
            int count = 1;
            ListNode currentNode = first;
            if (first == null)
            {
                return 0;
            }
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                count++;
            }

            return count;
        }

        public override String ToString()
        {
            ListNode node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }

        public bool ContainsUser(User user) {

            ListNode currentNode = first;
            if (first == null)
            {
                return false;
            }
            do {
                if (currentNode.Data.Id == user.Id) {
                    return true;
                }
            }
            while (currentNode.Next != null);
            return false; 
        }

        public void InsertUserSorted(User user) {
            if (first == null) {
                first = new ListNode(user, null!);
            }
            ListNode currentNode = first;
            ListNode? previousNode = null!;
            do {
                if(user.Name.CompareTo(currentNode.Data.Name) <= 0)
                {
                    ListNode newNode = new ListNode(user, currentNode);
                    if (previousNode != null)
                    {
                        previousNode.Next = newNode;
                    }
                    else {
                        first = newNode;
                    }
                    return;
                }
            }
            while(currentNode!= null);
        }
    }
}