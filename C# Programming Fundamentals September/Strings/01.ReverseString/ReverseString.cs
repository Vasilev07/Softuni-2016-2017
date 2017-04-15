namespace _01.ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var reversedInputText = inputText.Reverse();

            foreach (var reversedText in reversedInputText)
            {
                Console.Write(reversedText);
            }
            Console.WriteLine();
        }
    }
}
