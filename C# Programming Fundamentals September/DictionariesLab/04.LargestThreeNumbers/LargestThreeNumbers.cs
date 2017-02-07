namespace _04.LargestThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
