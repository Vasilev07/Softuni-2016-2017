using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RealRoots
{
    class RealRoots
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (discriminant == 0)
            {
                double root = -(b) / 2 * a;
                Console.WriteLine($"One real root, {root}");
            }
            else
            {
                double rootOne = -(b) + (Math.Sqrt(discriminant)) / 2 * a;
                double rootTwo = -(b) - (Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine($"Two real roots, {rootOne} {rootTwo}" );
            }
        }
    }
}
