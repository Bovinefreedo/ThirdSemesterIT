using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A13Hashing
{
    public class HashSetChaining : IHashing
    {
        private Node[] buckets;
        private int currentSize;

        private class Node
        {
            public Node(Object data, Node next)
            {
                this.Data = data;
                this.Next = next;
            }
            public Object Data { get; set; }
            public Node Next { get; set; }
        }

        public HashSetChaining(int size)
        {
            buckets = new Node[size];
            currentSize = 0;
        }

        public bool Contains(Object x)
        {
            int h = HashValue(x);
            Node bucket = buckets[h];
            bool found = false;
            while (!found && bucket != null)
            {
                if (bucket.Data.Equals(x))
                {
                    found = true;
                }
                else
                {
                    bucket = bucket.Next;
                }
            }
            return found;
        }

        public bool Add(Object x)
        {
            int h = HashValue(x);

            Node bucket = buckets[h];
            bool found = false;
            while (!found && bucket != null)
            {
                if (bucket.Data.Equals(x))
                {
                    found = true;
                }
                else
                {
                    bucket = bucket.Next;
                }
            }

            if (!found)
            {
                Node newNode = new Node(x, buckets[h]);
                buckets[h] = newNode;
                currentSize++;
            }

            return !found;
        }

        public bool Remove(Object x)
        {
            int h = HashValue(x);
            Node previousNode = null;
            Node currentNode = buckets[h];
            while (currentNode != null) 
            {                 {
                    if (currentNode.Data.Equals(x))
                    {
                        if (previousNode != null)
                        {
                            previousNode.Next = currentNode.Next;
                        }
                        else
                        {
                            buckets[h] = currentNode.Next;
                        }
                        currentSize--;
                        return true;
                    }
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }

        private int HashValue(Object x)
        {
            int h = x.GetHashCode();
            if (h < 0)
            {
                h = -h;
            }
            h = h % buckets.Length;
            return h;
        }

        public int Size()
        {
            return currentSize;
        }

        public override String ToString()
        {
            String result = "";
            for (int i = 0; i < buckets.Length; i++)
            {
                Node temp = buckets[i];
                if (temp != null)
                {
                    result += i + "\t";
                    while (temp != null)
                    {
                        result += temp.Data + " (h:" + HashValue(temp.Data) + ")\t";
                        temp = temp.Next;
                    }
                    result += "\n";
                }
            }
            return result;
        }
    }
}
