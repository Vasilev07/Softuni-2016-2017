using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var number = 1;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += number;
                Console.WriteLine(number);
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
