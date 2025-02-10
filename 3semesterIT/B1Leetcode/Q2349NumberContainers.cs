using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.B1Leetcode
{
    public class Q2349NumberContainers
    {
        private Dictionary<int, int> containers = new Dictionary<int, int>();
        private Dictionary<int, SortedSet<int>> keysByValue = new Dictionary<int, SortedSet<int>>();

        public Q2349NumberContainers(){}

        public void Change(int index, int number)
        {
            if (containers.ContainsKey(index)) 
                keysByValue[containers[index]].Remove(index);
            if (!keysByValue.ContainsKey(number))
                keysByValue[number] = new SortedSet<int>();
            containers[index] = number;
            keysByValue[number].Add(index);
        }

        public int Find(int number)
        {
            if (!keysByValue.ContainsKey(number) || keysByValue[number].Count == 0)
                return -1;
            else return keysByValue[number].Min();
        }

    }
}
