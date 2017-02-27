namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var cityPopulation = new Dictionary<string, Dictionary<string, long>>();
            var countryPopulation = new Dictionary<string, long>();

            while (true)
            {
                var input = Console.ReadLine()
                .Split('|');

                if (input[0] == "report")
                {
                    break;
                }

                var city = input[0];
                var country = input[1];
                var population = input[2];
                if (!cityPopulation.ContainsKey(country) && !countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = 0L;
                    cityPopulation[country] = new Dictionary<string, long>();
                }
                if (!cityPopulation[country].ContainsKey(city))
                {
                    cityPopulation[country][city] = 0L;
                }

                countryPopulation[country] += long.Parse(population);
                cityPopulation[country][city] += long.Parse(population);
            }

            foreach (var item in countryPopulation.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0} (total population: {1})", item.Key, item.Value);

                var cities = cityPopulation[item.Key];

                foreach (var city in cities.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
