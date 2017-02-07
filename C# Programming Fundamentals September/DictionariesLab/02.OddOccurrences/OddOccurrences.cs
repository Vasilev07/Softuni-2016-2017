namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                    .ToLower()
                   .Split(' ')
                   .ToList();

            var dict = new Dictionary<string, int>();
            var holder = new List<string>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }
           
            foreach (var word in dict)
            {
                if (word.Value % 2 !=0)
                {
                    holder.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", holder));

        }
    }
}
