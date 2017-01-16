using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roofs = n / 2;
            int downs =((n*2) - 4) - (2* roofs);
            //roof
            Console.Write("/{0}\\{1}/{0}\\", new string('^', roofs), new string('_', downs));
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                if (i == n - 3)
                {
                    Console.Write("|{0}{1}{0}|", (new string(' ', (((n * 2) - 2)/2)-(downs/2))), new string('_', downs));
                }
                else
                {
                    Console.Write("|{0}|", new string(' ', (n * 2) - 2));
                }
                Console.WriteLine();
            }
            Console.Write("\\{0}/{1}\\{0}/", new string('_', roofs),new string(' ', downs));
            Console.WriteLine();
        }
    }
}
