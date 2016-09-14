using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerimeterAndAreaOfCircle
{
    class PerimeterAndAreaOfCircle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine($"{perimeter} {area}");
        }
    }
}
