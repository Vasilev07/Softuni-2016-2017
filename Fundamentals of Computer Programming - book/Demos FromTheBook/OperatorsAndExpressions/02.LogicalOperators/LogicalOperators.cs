using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LogicalOperators
{
    class LogicalOperators
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((5 > 7) ^ (a == b));

            //Laws of Morgan
            bool firstLaw = !(a && b) == (!a || !b);
            bool secondLaw = !(a || b) == (!a && !b);


        }
    }
}
