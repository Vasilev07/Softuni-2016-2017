using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bestStart = 0;
            var bestLength = 1;
            var start = 0;
            var length = 1;
            for (int i = 1; i < number.Count; i++)
            {
                if (number[start] == number[i])
                {
                    length++;
                    if (bestLength < length)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }   
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(number[i] + " ");

            }
            Console.WriteLine();

        }
    }
}
