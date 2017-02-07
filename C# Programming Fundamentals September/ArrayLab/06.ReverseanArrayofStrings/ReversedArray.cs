namespace _06.ReverseanArrayofStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ReversedArray
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            var reversedText = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                reversedText[reversedText.Length - i - 1] = text[i];
            }

            Console.WriteLine(string.Join(" ", reversedText));
        }
    }
}
