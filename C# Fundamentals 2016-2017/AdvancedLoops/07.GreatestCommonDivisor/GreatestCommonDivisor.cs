using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int greater = Math.Max(a, b);
            int lesser = Math.Min(a, b);
           
            while (lesser != 0)
            {
                var divisor = lesser;
                lesser = greater % lesser;
                greater = divisor;
                
                
            }
            Console.WriteLine(greater);
        }
    }
}
