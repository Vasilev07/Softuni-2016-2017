using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanType
{
    class BooleanType
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            // which one is greater
            bool greaterAB = a > b;
            //is a equal to 1 
            bool equalA1 = a == 1;
            //print result on the console
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }

            Console.WriteLine("greaterAb = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);
        }
    }
}
