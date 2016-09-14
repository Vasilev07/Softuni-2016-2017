using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int lenghtOfGrape = int.Parse(Console.ReadLine());
            double grapeKilosPerSquareMeter = double.Parse(Console.ReadLine());
            int litersOfWine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            double totalGrape = lenghtOfGrape * grapeKilosPerSquareMeter;
            double wine = totalGrape * 0.4D / 2.5;
            if (wine >= litersOfWine)
            {
                double surplus = wine - litersOfWine;
                double forWorkers = surplus / numberOfWorkers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine) );
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(surplus), Math.Ceiling(forWorkers));
            }
            else
            {
                double lack = litersOfWine - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(lack));
            }
            
            


        }
    }
}
