using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareTwoRealNUmbers
{
    class CompareTwoRealNUmbers
    {
        static void Main(string[] args)
        {
            //compare 2 real numbers with 0.000001 precision
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            bool equal = Math.Abs(a-b) < 0.000001;
            if (equal)
            {
                Console.WriteLine("A = B");
            }
             else
            {
                Console.WriteLine("A != B");
            }
        }
    }
}
