using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.WithinTheCircle
{
    class WithinTheCircle
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r = 5;
            if ((x*x) + (y*y) <= r*r)
            {
                Console.WriteLine("In the Circle");
            }
            else
            {
                Console.WriteLine("Out of the circle");
            }
        }
    }
}
