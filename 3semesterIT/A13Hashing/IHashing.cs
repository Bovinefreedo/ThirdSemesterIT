using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A13Hashing
{

    public interface IHashing
    {
        public bool Add(Object x);
        public bool Remove(Object x);
        public bool Contains(Object x);
        public int Size();
    }
}
