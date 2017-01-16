using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Subsets
{
    class Subsets
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int flagFound = 0;

            if ((a + b) == 0)
            {
                Console.WriteLine($"{a} {b} {flagFound = 1}");
            }
            if ((a + c) == 0)
            {
                Console.WriteLine($"{a} {c} {flagFound = 1}");
            }
            if ((a + d) == 0)
            {
                Console.WriteLine($"{a} {d} {flagFound = 1}");
            }
            if ((a + e) == 0)
            {
                Console.WriteLine($"{a} {e} {flagFound = 1}");
            }
            if ((b + c) == 0)
            {
                Console.WriteLine($"{b} {c} {flagFound = 1}");
            }
            if ((b + d) == 0)
            {
                Console.WriteLine($"{b} {d} {flagFound = 1}");
            }
            if ((b + e) == 0)
            {
                Console.WriteLine($"{b} {e} {flagFound = 1}");
            }

        }
    }
}
