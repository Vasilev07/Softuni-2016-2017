using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    public class Program
    {
        public static void Main()
        {
            var countryInfo = new Dictionary<string, SortedDictionary<string, long>>();
            var countryTotal = new Dictionary<string, long>();
            while (true)
            {
                var information = Console.ReadLine()
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                var city = information[0];
                if (city == "report")
                {
                    break;
                }

                
                var country = information[1];
                var population = int.Parse(information[2]);
                if (!countryInfo.ContainsKey(country))
                {
                    countryInfo[country] = new SortedDictionary<string, long>();
                }
                if (!countryInfo[country].ContainsKey(city))
                {
                    countryInfo[country][city] = population;
                }
                else
                {
                    countryInfo[country][city] += population;
                }

                if (!countryTotal.ContainsKey(country))
                {
                    countryTotal[country] = population;
                }
                else
                {
                    countryTotal[country] += population;
                }
                    
            }
            foreach (var info in countryTotal.OrderByDescending(key => key.Value))
            {
              
                Console.WriteLine($"{info.Key} (total population: {info.Value})");
                
                foreach (var item in countryInfo[info.Key].OrderByDescending(p=>p.Value))
                    {
                        Console.WriteLine($"=>{item.Key}: {item.Value}");
                    }
            }
        }
    }
}
