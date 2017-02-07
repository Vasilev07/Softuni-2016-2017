namespace _04.TrippleSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TrippleSum
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var containSum = true;

            for (int a = 0; a < numbers.Length; a++)
            {
                var sum = 0;
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    sum = numbers[a] + numbers[b];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == sum)
                        {
                            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                            containSum = true;
                            break;
                        }
                    }
                }
            }
            if (!containSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}

