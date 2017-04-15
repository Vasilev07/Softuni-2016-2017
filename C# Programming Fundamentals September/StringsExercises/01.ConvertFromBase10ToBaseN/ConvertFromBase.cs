namespace _01.ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    public class ConvertFromBase
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                 .Trim()
                 .Split(' ')
                 .ToList();

            var number = BigInteger.Parse(numbers[1]);
            var basse = BigInteger.Parse(numbers[0]);

            var holder = new List<BigInteger>();

            while (number >= basse)
            {
                var system = number % basse;
                holder.Add(system);
                number /= basse;
                if (number < basse)
                {
                    holder.Add(number);
                }

            }

            var result = new List<BigInteger>();

            for (int i = holder.Count - 1; i >= 0; i--)
            {
                result.Add(holder[i]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
