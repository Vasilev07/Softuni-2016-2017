﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Sums_3_Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b;
            int sum2 = b + c;
            int sum3 = a + c;
            if (sum == c)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            }
            else if (sum2 == a)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b,c), a);
            }
            else if (sum3 == b)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a,c), Math.Max(a,c), b);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
