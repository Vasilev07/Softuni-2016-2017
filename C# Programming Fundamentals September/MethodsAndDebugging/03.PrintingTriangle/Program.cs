using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangleTopPart(int.Parse(Console.ReadLine()));
        }

        static void PrintTriangleTopPart(int n)
        {

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (var i = n - 1; i >= 1; i--)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }



    }
}
