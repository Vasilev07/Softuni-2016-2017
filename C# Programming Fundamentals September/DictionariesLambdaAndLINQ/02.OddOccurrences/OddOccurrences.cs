using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                 .Split()
                 .ToList();

            var dict = new Dictionary<string, int>();
            var result = new List<string>();
            foreach (var word in text)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                
                    dict[word]++;
                
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }



            Console.WriteLine(string.Join(", ", result));

        }
    }
}
