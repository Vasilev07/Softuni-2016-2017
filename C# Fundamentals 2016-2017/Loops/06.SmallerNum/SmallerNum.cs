using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SmallerNum
{
    class SmallerNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long min = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n-1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
