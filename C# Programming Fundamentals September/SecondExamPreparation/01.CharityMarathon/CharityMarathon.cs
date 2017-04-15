using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonInDays = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var laps = decimal.Parse(Console.ReadLine());
            var lapLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            var maxRunners = marathonInDays * trackCapacity;

            if (maxRunners <= runners)
            {
                runners = marathonInDays * trackCapacity;
            }


            decimal totalMeters = (runners * laps * lapLength);
            decimal totalKilometers = totalMeters / 1000;

            decimal moneyRaised = (totalKilometers * moneyPerKm);
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}