namespace _07.CountNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            numbers.Sort();

            var counter = 1;
            var previous = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                var current = numbers[i];
                if (previous == current)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{previous} -> {counter}");
                    counter = 1;
                }
                previous = current;
            }
            Console.WriteLine($"{previous} -> {counter}");  
        }
    }
}
