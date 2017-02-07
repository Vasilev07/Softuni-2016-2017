using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldandSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var leftSide = new int[numbers.Length / 4];
            var rightSide = new int[numbers.Length / 4];
            var middleSide = new int[numbers.Length / 2];

            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSide[i] = numbers[numbers.Length / 4 - i-1];
                rightSide[i] = numbers[numbers.Length - 1 - i];
            }

            for (int i = 0; i < rightSide.Length; i++)
            {
                middleSide[i] = leftSide[i] + numbers[numbers.Length / 4 + i];
                middleSide[numbers.Length / 4 + i] = rightSide[i] + numbers[numbers.Length / 2 + i];
            }

            Console.WriteLine(string.Join(" ", middleSide));
        }
    }
}
