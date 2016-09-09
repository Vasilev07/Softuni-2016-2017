using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.WithinTheCircleOutOfTheRectangle
{
    class WithinTheCircleOutOfTheRectangle
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r = 5;
            if (((x * x) + (y * y) <= r * r) && (x <= -1 && y <= -1 && x <= 5 && y <= 5))
            {
                Console.WriteLine("In the Circle" + " " + "In rectangle");
            }
            else
            {
                Console.WriteLine("Out of the circle");
            }
        }
    }
}
