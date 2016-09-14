using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ThreeNumbersInVirtualColum
{
    class ThreeNumbersInVirtualColum
    {
        static void Main(string[] args)
        {
            int hexNumber = 2013;
            Console.WriteLine("|0x{0, -8:X}|", hexNumber);
            double fractNumber = -1.856;
            Console.WriteLine("|{0, -10:F2}|", fractNumber);
            double positive = 1.856;
            Console.WriteLine("|{0, -10:F2}|", positive);

        }
    }
}
