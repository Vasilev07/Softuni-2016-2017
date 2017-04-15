using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    public class PairsByDifference
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var difference = int.Parse(Console.ReadLine());

            var counter = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers[i];
                for (int j = 1; j < numbers.Length; j++)
                {
                    var second = numbers[j];
                    if (current + difference == second || current - difference == second)
                    {
                        counter++;
                    }
                }
            }
            double result = Math.Ceiling(counter / 2);
            Console.WriteLine(result);
        }
    }
}
