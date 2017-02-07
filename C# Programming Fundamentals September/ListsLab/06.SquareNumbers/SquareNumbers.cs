namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);
                if (square == (int)square)
                {
                    squareNumbers.Add(currentNumber);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();

            Console.WriteLine(string.Join(" ", squareNumbers));

        }
    }
}
