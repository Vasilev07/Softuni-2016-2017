using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IfGrater
{
    class IfGreater
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            

            if (first > second)
            {
                
                Console.WriteLine($"First is greater {first}");
            }
            else if (second > first)
            {
                Console.WriteLine($"Second is greater {second}");
            }
        }
    }
}
