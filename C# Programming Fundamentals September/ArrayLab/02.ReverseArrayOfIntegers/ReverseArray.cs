namespace _02.ReverseArrayOfIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ReverseArray
    {
         public static void Main()
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var numbers = new int[numberOfElements];
            var reversedNumbers = new int[numbers.Length];

            for (int i = 0; i < numberOfElements; i++)
            {
                var currentNum = int.Parse(Console.ReadLine()); ;
                numbers[i] = currentNum;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumbers[reversedNumbers.Length - 1 - i] = numbers[i];
            }

            Console.WriteLine(string.Join(" ", reversedNumbers));
        }
    }
}
