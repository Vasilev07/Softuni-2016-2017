namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            var chars = Console.ReadLine()
                .Split(' ')
                .ToList();
            for (int i = 0; i < chars.Count; i++)
            {
                chars[i].Reverse();
            }
        

            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
           

           
        }
    }
}
