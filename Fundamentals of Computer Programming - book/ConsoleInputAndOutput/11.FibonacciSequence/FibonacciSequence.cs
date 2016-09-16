using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FibonacciSequence
{
    class FibonacciSequence
    {
        public static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (long i = 0; i < 20; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
