namespace _02.RotateAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var rotations = int.Parse(Console.ReadLine());

            var sum = new int[numbers.Length];
            for (int i = 0; i < rotations; i++)
            {
               var lastDigit = numbers[numbers.Length - 1];
                for (int j = numbers.Length-1; j > 0 ; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastDigit;

                for (int k = 0; k < numbers.Length; k++)
                {
                    sum[k] += numbers[k];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

         
        }
    }
}
