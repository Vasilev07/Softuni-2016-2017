using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //printig top 
            for (int row = 1; row <= n; row++)
            {
                for (int spaces= 0; spaces < n - row; spaces++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int stars = 0; stars < row - 1; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n - 1; row++)
            {
                for (int spaces = 1; spaces <= row; spaces++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int stars = n-2; stars > row - 1; stars--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


        }
    }
}
