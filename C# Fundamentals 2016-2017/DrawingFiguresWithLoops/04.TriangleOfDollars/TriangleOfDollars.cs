using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            int cycle = 0;
          
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                cycle++;
                if (cycle == 10)
                {
                    break;
                }
                if(n % 2 == 0)
                {
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }

            }
          
        }
    }
}