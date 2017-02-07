namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

           
            for (int i = 1; i < numbers.Count; i++)
            {
              
                var currentNumber = numbers[i];
                if (numbers[i] == numbers[i-1])
                {
                    numbers[i] = numbers[i] + numbers[i-1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
