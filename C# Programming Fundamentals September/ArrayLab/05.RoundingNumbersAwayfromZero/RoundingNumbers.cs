namespace _05.RoundingNumbersAwayfromZero
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var rounded = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                rounded[i] = (int)(Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {rounded[i]}");
            }
        }
    }
}
