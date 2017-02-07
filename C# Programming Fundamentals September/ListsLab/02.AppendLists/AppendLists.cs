namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Trim()
                .Split('|')
                .ToList();
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }

        //tests
        //1 2 3 |4 5 6 |  7  8 => 7 8 4 5 6 1 2 3
        //7 | 4  5|1 0| 2 5 |3 => 3 2 5 1 0 4 5 7
        //1| 4 5 6 7  |  8 9 => 8 9 7 6 5 4 1
    }
}

