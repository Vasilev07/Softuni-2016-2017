using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}
