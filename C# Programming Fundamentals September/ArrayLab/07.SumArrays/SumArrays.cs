namespace _07.SumArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumArrays
    {
        public static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var secondArr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
          
            if (firstArr.Length > secondArr.Length)
            {
                var sum = new int[firstArr.Length];
                for (int i = 0; i < firstArr.Length; i++)
                {
                    sum[i] = firstArr[i] + secondArr[i % secondArr.Length];
                }
                Console.WriteLine(string.Join(" ", sum));
            }
            if (firstArr.Length < secondArr.Length)
            {
                var sum = new int[secondArr.Length];
                for (int i = 0; i < secondArr.Length; i++)
                {
                    sum[i] = secondArr[i] + firstArr[i % firstArr.Length];
                }
                Console.WriteLine(string.Join(" ", sum));
            }
            if(firstArr.Length == secondArr.Length)
            {
                var sum = new int[firstArr.Length];
                for (int i = 0; i < firstArr.Length; i++)
                {
                    sum[i] = secondArr[i] + firstArr[i];
                }
                Console.WriteLine(string.Join(" ", sum));
            }

        }
    }
}
