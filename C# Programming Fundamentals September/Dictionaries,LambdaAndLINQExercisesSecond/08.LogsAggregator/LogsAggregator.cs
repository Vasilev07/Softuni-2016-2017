using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var holder = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                    

                var ip = input[0];
                var name = input[1];
                var duration = int.Parse(input[2]);
                if (!holder.ContainsKey(name))
                {
                    holder.Add(name, new SortedDictionary<string, int>());
                }
                if (!holder[name].ContainsKey(ip))
                {
                    holder[name][ip] = 0;
                }

                holder[name][ip] += duration;


            }

            foreach (var item in holder)
            {
                var sum = item.Value.Values.Sum()
                    ;
                Console.Write($"{item.Key}: {sum}");
                Console.Write(" [);
                Console.Write(string.Join(", ", item.Value.Keys));
                Console.WriteLine(']');
            }
        }
    }
}
