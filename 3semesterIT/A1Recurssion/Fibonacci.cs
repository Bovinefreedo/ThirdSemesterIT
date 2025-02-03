using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public  class Fibonacci
    {
        public static int fib(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            Console.WriteLine(n);
            return fib(n - 1) + fib(n - 2);
        }
    }
}
