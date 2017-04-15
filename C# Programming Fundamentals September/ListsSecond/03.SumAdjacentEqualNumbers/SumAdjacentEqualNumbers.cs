using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var first = numbers[i];

                for (int j = 1; j < numbers.Count; j++)
                {
                    var second = numbers[j];
                    if (first == second)
                    {
                        numbers.Insert(i, first + second);
                        numbers.Remove(first);
                        numbers.Remove(second);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
