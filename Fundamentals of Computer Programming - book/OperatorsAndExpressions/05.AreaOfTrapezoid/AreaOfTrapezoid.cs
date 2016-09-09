using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AreaOfTrapezoid
{
    class AreaOfTrapezoid
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double surface = (a + b) * h / 2;
            Console.WriteLine(surface);
        }
    }
}
