namespace _09.Extract_Middle_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Array
    {
        public static void Main()
        {
           var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           var list = new List<int>();

            if (input.Length == 1)
            {
                list.Add(input[input.Length - 1]);
            }
            else if (input.Length % 2 != 0)
            {
                list.Add(input[(input.Length / 2) - 1]);
                list.Add(input[(input.Length / 2) ]);
                list.Add(input[(input.Length / 2) +1]);
            }
            else if (input.Length % 2 == 0)
            {
                list.Add(input[(input.Length / 2) - 1]);
                list.Add(input[(input.Length / 2)]);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}