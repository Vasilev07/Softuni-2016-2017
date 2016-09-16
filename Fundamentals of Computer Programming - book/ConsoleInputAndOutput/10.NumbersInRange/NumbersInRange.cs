using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NumbersInRange
{
    class NumbersInRange
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
