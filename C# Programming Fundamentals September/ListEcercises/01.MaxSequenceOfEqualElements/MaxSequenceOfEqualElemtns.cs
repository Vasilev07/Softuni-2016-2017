namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var count = 1;
            var position = 0;
            var maxCount = 1;
            var previous = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == previous)
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        position = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
                previous = currentNumber;
            }

            for (int i = position; i < position + maxCount; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}

