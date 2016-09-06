using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            var side = int.Parse(Console.ReadLine());
            int areaOfSquare = side * side;
            Console.WriteLine(areaOfSquare);
        }
    }
}
