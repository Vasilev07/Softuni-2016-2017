using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //printig top row
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            //printig middle
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int r = 0; r < n - 2; r++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("|");
            }
            //printing last row
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");


        }
    }
}
