using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        { 
          double x1 = double.Parse(Console.ReadLine());
          double y1 = double.Parse(Console.ReadLine());
          double x2 = double.Parse(Console.ReadLine());
          double y2 = double.Parse(Console.ReadLine());
          double area = Math.Abs((x1 - x2) * (y1 - y2));
          Console.WriteLine(area);
            if (x1 > x2 && y1 > y2)
            {
                double perimeter = 2 * ((x1 - x2) + (y1 - y2));
                Console.WriteLine(perimeter);
            }
            else if (x1 < x2 && y1 < y2)
            {
                 double perimeter = 2 * ((x2 - x1) + (y2 - y1));
                 Console.WriteLine(perimeter);
            }
            else if (x1 > x2 && y1 < y2)
            {
                double perimeter = 2 * ((x1 - x2) + (y2 - y1));
                Console.WriteLine(perimeter);
            }
            else
            {
                double perimeter = 2 * ((x2 - x1) + (y1 - y2));
                Console.WriteLine(perimeter);
            }
    
        }
    }
}
