namespace _09.ExtractMiddleElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExtractMiddleElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            if(numbers.Length == 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("{" + " " + numbers[i] + " " + "}");
                }
            }
            else if (numbers.Length % 2 == 0)
            {
                for (int i = numbers.Length/2-1; i <= numbers.Length/2; i++)
                {
                    Console.WriteLine("{" + " " + numbers[i] + " " + "}");
                }
            }
            else
            {
                for (int j=1 ,i = numbers.Length / 2 - j; i <= numbers.Length / 2 + 1 ; i++, j++)
                {
                    Console.WriteLine("{" + " " + numbers[i] + " " + "}");
                }
            }
            

        }
    }
}
