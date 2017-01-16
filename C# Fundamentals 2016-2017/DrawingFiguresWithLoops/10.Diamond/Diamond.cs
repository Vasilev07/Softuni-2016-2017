using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            int mid = 1;
            int leftRight = (n - stars) / 2;
            if (n != 1 && n !=2)
            {
                if (n % 2 == 0)
                {
                    mid = 2;
                    stars = 2;
                    leftRight = (n - stars) / 2;
                }
                Console.Write("{0}{1}{0}", new string(' ', leftRight), new string('*', stars));
                Console.WriteLine();
                leftRight--;
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write(new string(' ', leftRight));
                    Console.Write("*");
                    Console.Write(new string(' ', mid));
                    Console.Write("*");
                    Console.Write(new string(' ', leftRight));

                    mid += 2;
                    leftRight -= 1;

                    Console.WriteLine();
                }
                leftRight = 1;
                mid -= 4;
                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string(' ', leftRight));
                    Console.Write("*");
                    Console.Write(new string(' ', mid));
                    Console.Write("*");
                    Console.Write(new string(' ', leftRight));
                    mid -= 2;
                    leftRight += 1;
                    Console.WriteLine();
                }

                Console.Write("{0}{1}{0}", new string(' ', leftRight), new string('*', stars));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('*', n));
            }
            
        }
    }
}
