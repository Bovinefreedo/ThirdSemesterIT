using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A13Hashing
{
    public interface Map<K, V>
    {
        public V Get(K key);
        public V Put(K key, V value);
        public V Remove(K key);
        public bool IsEmpty();
        public int Size();
    }

    public class Node<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public Node<K, V> Next { get; set; }

        public Node(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    public class HashMap<K, V> : Map<K, V>
    {
        Node<K, V>[] buckets = new Node<K, V>[10];

        public V Get(K key)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public V Put(K key, V value)
        {
            int h = HashValue(key);
            Node<K, V> newNode = new Node<K, V>(key, value);
            if (buckets[h] == null)
            {
                buckets[h] = newNode;
                return value;
            }
            else
            {
                Node<K, V> current = buckets[h];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                return value;
            }
        }

        public V Remove(K key)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
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
    }
}
