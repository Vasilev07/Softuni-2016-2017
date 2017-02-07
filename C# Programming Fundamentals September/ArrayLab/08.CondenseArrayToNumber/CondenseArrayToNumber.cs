namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var condensed = new int[numbers.Length - 1];
            var len = condensed.Length-1;
            while (len > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                len--;
                numbers = condensed;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
