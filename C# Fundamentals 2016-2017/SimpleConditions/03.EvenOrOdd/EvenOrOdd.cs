using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int check = int.Parse(Console.ReadLine());
            if (check % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
