using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdvikling
{
    public class Calculator
    {
        public int add(int n1, int n2) {
            return n1+n2;
        }

        public int subtract(int n1, int n2) {
            return n1-n2;
        }

        public double divide(int n1, int n2) {
            if (n2 == 0) {
                throw new DivideByZeroException();
            }

            return n1 / n2;
        }
    }
}
