using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersTo1000EndOn7
{
    class NumbersTo1000EndOn7
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 1000; i++)
            {
                if (i % 10 ==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
