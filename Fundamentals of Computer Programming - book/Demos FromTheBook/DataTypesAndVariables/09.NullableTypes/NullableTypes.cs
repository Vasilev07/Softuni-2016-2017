using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.NullableTypes
{
    class NullableTypes
    {
        static void Main(string[] args)
        {
            int i = 5;
            int? ni = i;

            Console.WriteLine(ni);
            Console.WriteLine(i);

            ni = null;
            Console.WriteLine(ni.HasValue);

            i = ni.GetValueOrDefault();
            Console.WriteLine(i);
        }
    }
}
