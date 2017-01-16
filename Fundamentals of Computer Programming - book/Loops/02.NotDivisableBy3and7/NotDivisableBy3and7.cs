using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NotDivisableBy3and7
{
        class NotDivisableBy3and7
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

//int n = int.Parse(Console.ReadLine());
//int minValue = int.MaxValue;
//int maxValue = int.MinValue;
