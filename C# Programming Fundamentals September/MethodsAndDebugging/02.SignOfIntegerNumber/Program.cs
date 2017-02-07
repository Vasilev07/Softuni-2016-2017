using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign();
        }
        static void PrintSign()
        {
            var input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {input} is positive."); 
            }
        }
    }
}
