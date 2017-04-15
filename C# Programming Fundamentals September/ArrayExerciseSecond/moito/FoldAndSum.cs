using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var leftSide = (numbers.Take(numbers.Length / 4).Reverse()).ToArray();
            var middleSide = (numbers.Skip(numbers.Length / 4).Take(numbers.Length/2)).ToArray();
            var rightSide = (numbers.Skip(numbers.Length/4 + numbers.Length/2).Take(numbers.Length/2)).Reverse().ToArray();
            var firstRow = leftSide.Concat(rightSide).ToArray();
            var summed = new int[numbers.Length/2];
            for (int i = 0; i < summed.Length; i++)
            {
                summed[i] = firstRow[i] + middleSide[i];
            }

            Console.WriteLine(string.Join(" ", summed));
        }
    }
}
