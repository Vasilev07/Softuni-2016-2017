using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CompoundAssignmentOperators
{
    class CompoundAssignmentOperators
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;
            x *= y; //same as x = x * y;
            Console.WriteLine(x);

            Console.WriteLine(y *= 2);//8
            int z = y - 3;//both y and z = 3
            Console.WriteLine(z);//3
            Console.WriteLine(x |= 2);//7
            Console.WriteLine(x += 3);//10
            Console.WriteLine(x /= 2);//5

            //conditional operator ?:

            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a > b" : "b <= a");

            //operator ??
            int? h = 5;
            Console.WriteLine(h ?? -1);//5
            string name = null;
            Console.WriteLine(name ?? "(no name)");//(no name)

            //other operators
            int j = 6;
            int k = 3;
            Console.WriteLine(j + k / 2);// 6 + 1
            Console.WriteLine((j + k) / 2);// 9 / 2 = 4 

            string s = "beer";
            Console.WriteLine(s is string);

            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");//Unspecified
            Console.WriteLine(notNullString ?? "Specified");//beer
        }
    }
}
