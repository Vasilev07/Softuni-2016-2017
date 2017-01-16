using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggerNum
{
    class BiggerNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n-1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
