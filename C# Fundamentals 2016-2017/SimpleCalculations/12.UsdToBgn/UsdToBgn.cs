using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.UsdToBgn
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            double usdValue = double.Parse(Console.ReadLine());
            double usdToBgn = usdValue * 1.79549D;
            Console.WriteLine("{0:F2}",usdToBgn);
        }
    }
}
