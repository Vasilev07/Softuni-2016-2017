namespace _04.SplitbyWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitWords
    {
        public static void Main()
        {
            var separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '\\', '\'', '\\', '/', '[', ']' };
            var text = Console.ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();
            


            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
