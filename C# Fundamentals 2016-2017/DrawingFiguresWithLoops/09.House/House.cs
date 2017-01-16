using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            int blank = (n - stars) / 2;
            //roof  
            for (int i = 0; i < (n + 1) / 2; i++)
            {

                Console.Write(new string(' ', blank));
                Console.Write(new string('*', stars));
                Console.Write(new string(' ', blank));
                blank--;
                stars += 2;
                Console.WriteLine();
            }
            //body
            for (int i = (n + 1) / 2; i < n; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n-2));
                Console.Write(new string('|', 1));
                Console.WriteLine();
            }
        }
    }
}
