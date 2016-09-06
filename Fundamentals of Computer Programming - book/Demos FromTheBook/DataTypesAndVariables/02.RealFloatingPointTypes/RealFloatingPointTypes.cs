using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RealFloatingPointTypes
{
    class RealFloatingPointTypes
    {
        static void Main(string[] args)
        {
            float floatPi = 3.14F;
            Console.WriteLine(floatPi);
            double doublePi = 3.14;
            Console.WriteLine(doublePi);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);
        }
    }
}
