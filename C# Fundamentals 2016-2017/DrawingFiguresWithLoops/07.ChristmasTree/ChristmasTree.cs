using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ', n + 1) + "|");
            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 0; spaces < n-row; spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int rightStars  = 0; rightStars < row-1; rightStars++)
                {
                    Console.Write("*");
                    
                }
                Console.Write(" | ");
                

                for (int leftStars = n-row; leftStars < n; leftStars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
