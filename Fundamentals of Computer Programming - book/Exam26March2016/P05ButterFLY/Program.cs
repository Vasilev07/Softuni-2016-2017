using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ButterFLY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n-2; i++)
            {
               
                if (i % 2 ==0)
                {
                    Console.Write("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.Write("{0}\\ /{0}", new string('*', n - 2));
                }
             
                Console.WriteLine();
            }
            Console.Write("{0}@{0}", new string(' ', n - 1));
            Console.WriteLine();

            for (int i = 1; i <= n - 2; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                {
                    Console.Write("{0}/ \\{0}", new string('*', n - 2));
                }

                Console.WriteLine();
            }
        }
    }
}
