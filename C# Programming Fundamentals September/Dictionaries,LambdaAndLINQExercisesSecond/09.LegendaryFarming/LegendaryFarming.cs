using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var items = Console.ReadLine()
                .Split()
                .ToArray();
            var holder = new Dictionary<string, int>();


            for (int i = 0; i < items.Length; i += 2)
            {
                var currentKey = items[i + 1];
                var currentValue = items[i];
                currentKey.ToLower();
                if (!holder.ContainsKey(currentKey))
                {
                    holder[currentKey] = int.Parse(currentValue);
                }
                else
                {
                    holder[currentKey] += int.Parse(currentValue);
                }
            }

            foreach (var item in holder)
            {
                if (item.Key == "motes" && item.Value >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    holder["motes"] -= 250;
                    
                }
                if (item.Key == "shards" && item.Value >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    holder["shards"] -= 250;
                    
                }
               if (item.Key == "fragments" && item.Value >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    holder["fragments"] -= 250;
                }
               
                    Console.WriteLine($"{item.Key}: {item.Value}");
            
                
            }

        }
    }
}
