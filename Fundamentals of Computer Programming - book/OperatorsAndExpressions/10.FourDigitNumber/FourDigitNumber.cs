using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd % 10;
            int b = (abcd / 10) % 10;
            int c = (abcd / 100) % 10;
            int d = (abcd / 1000) % 10;
            int sumOfDIgits = a + b + c + d;
            Console.WriteLine(sumOfDIgits);
            Console.WriteLine("{0}, {1}, {2}, {3}", d, c, b, a);
            Console.WriteLine("{0}, {1}, {2}, {3}", d, a, b, c);
            Console.WriteLine("{0}, {1}, {2}, {3}", a, c, b, d);


        }
    }
}
