namespace _03.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var numbersLenght = int.Parse(Console.ReadLine());

            var arrayHolder = new int[numbersLenght];
            
            for (int i = 0; i < numbersLenght; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                arrayHolder[i] = currentNumber;
            }

            Console.WriteLine($"Sum = {arrayHolder.Sum()}");
            Console.WriteLine($"Min = {arrayHolder.Min()}");
            Console.WriteLine($"Max = {arrayHolder.Max()}");
            Console.WriteLine($"Average = {arrayHolder.Average()}");

        }
    }
}
