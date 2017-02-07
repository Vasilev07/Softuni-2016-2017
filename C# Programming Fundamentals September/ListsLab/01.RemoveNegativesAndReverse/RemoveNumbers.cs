namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            numbers.Reverse();

            numbers.RemoveAll(x => x < 0);
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            //tests
            //10 -5 7 9 -33 50 => 50 9 7 10
            //7 -2 -10 1 => 1 7
            //-1 -2 -3 => empty
        }
    }
}
