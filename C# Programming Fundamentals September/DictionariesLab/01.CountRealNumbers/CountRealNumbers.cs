namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var numbersHolder = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersHolder.ContainsKey(number))
                {
                    numbersHolder[number] = 0;
                }
                numbersHolder[number]++;
            }

            foreach (var item in numbersHolder)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
