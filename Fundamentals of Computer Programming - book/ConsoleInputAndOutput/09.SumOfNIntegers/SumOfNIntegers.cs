using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNIntegers
{
    class SumOfNIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n -= 1;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.Write("Number [{0}]: ", i);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("Sum of these numbers is " + sum);
        }
    }
}
