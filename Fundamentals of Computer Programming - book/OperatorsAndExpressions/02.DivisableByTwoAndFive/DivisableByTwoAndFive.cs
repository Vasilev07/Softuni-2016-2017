using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DivisableByTwoAndFive
{
    class DivisableByTwoAndFive
    {
        static void Main(string[] args)
        {
            int someInt = int.Parse(Console.ReadLine());
            if ((someInt % 5 == 0) && (someInt % 7 == 0))
            {
                Console.WriteLine("Divisable by both 5 and 7");
            }
            else
            {
                Console.WriteLine(" NOT Divisable by both 5 and 7");

            }
        }
    }
}
