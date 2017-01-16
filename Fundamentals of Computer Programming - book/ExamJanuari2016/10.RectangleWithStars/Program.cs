using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfRows = n;
            if (n%2==0)
            {
                numberOfRows = n - 1;
            }
            Console.Write(new string('%', n * 2));
            Console.WriteLine();
            for (int row = 0; row < numberOfRows; row++)
            {
                if (row == numberOfRows / 2)
                {
                   
                    Console.Write("%{0}**{0}%", new string(' ', ((n * 2) - 4) / 2));
                    
                }
                else
                {
                    Console.Write("%{0}%", new string(' ', (n * 2) - 2));

                }
                Console.WriteLine();
            }
            Console.Write(new string('%', n * 2));
            Console.WriteLine();
        }
    }
}
