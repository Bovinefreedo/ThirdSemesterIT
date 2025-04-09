using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A13Hashing
{
    public class HashSetLinearProbing : IHashing
    {
        private Object[] buckets;
        private int currentSize;
        private enum State { DELETED }

        public HashSetLinearProbing(int bucketsLength)
        {
            buckets = new Object[bucketsLength];
            currentSize = 0;
        }

        public bool Contains(Object x)
        {
            int h = HashValue(x);
            for (int i = 0; i < buckets.Length; i++) { 
                int index = (h + i) % buckets.Length;

                if (buckets[index].Equals(x)) {
                    return true;
                }
                if (buckets[index] == null)
                {
                    return false; // Not found
                }
                
            }
            return false;
        }

        public bool Add(Object x)
        {
            if (currentSize >= buckets.Length)
            {
                return false; // HashSet is full
            }
            int h = HashValue(x);
            while (true)
            {
                if (buckets[h] == null || buckets[h].Equals(State.DELETED))
                {
                    buckets[h] = x;
                    currentSize++;
                    return true;
                }
                if (buckets[h].Equals(x))
                {
                    return false; 
                }
                h = (h + 1) % buckets.Length; // Linear probing
            }
        }

        public bool Remove(Object x)
        {
            int h = HashValue(x);
            for (int i = 0; i < buckets.Length; i++)
            {
                int index = (h + i) % buckets.Length;

                if (buckets[index].Equals(x))
                {
                    buckets[index] = State.DELETED;
                    currentSize--;
                    return true;
                }
                if (buckets[index] == null)
                {
                    return false;
                }

            }
            return false;
        }

        public int Size()
        {
            return currentSize;
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

        public override String ToString()
        {
            String result = "";
            for (int i = 0; i < buckets.Length; i++)
            {
                int value = buckets[i] != null && !buckets[i].Equals(State.DELETED) ?
                        HashValue(buckets[i]) : -1;
                result += i + "\t" + buckets[i] + "(h:" + value + ")\n";
            }
            return result;
        }

    }
}
