using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqMetersGrape = int.Parse(Console.ReadLine());
            double grapePerSqMeter = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrape = sqMetersGrape * grapePerSqMeter;
            double wine = (((40) * totalGrape)/100) / 2.5;

            if (wine < wineNeeded)
            {
                double x = wineNeeded - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(x));
            }
            if(wine >= wineNeeded)
            {
           
                double wineLeft = wine - wineNeeded;
                double winePerWorker = wineLeft / numberOfWorkers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(winePerWorker));
            }

        }

    }
}
