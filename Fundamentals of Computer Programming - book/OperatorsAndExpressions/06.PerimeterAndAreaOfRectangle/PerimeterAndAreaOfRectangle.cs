using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PerimeterAndAreaOfRectangle
{
    class PerimeterAndAreaOfRectangle
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int perimeter = 2 * (a + b);
            int area = a * b;
            Console.WriteLine(perimeter);
            Console.WriteLine(area);

        }
    }
}
