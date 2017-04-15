using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var racers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var zones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var indexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var racer in racers)
            {
                double fuel = racer.ToCharArray().First();

                for (int i = 0; i < zones.Count; i++)
                {
                    if (!indexes.Contains(i))
                    {
                        fuel -= zones[i];
                    }
                    else
                    {
                        fuel += zones[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{racer} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{racer} - fuel left {fuel:F2}");
                }
            }


            Console.WriteLine();
        }
    }
}
