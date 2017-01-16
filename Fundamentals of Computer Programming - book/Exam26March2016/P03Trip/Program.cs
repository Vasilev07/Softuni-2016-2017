using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (season == "winter")
            {
                if (budget <= 100)
                {
                    double result = (budget * 70) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", result);
                }
                else if (budget > 100 && budget <=1000)
                {
                    double result = (budget * 80) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", result);
                }
                else if (budget > 1000)
                {
                    double result = (budget * 90) / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", result);
                }
            }
            else if (season == "summer")
            {
                if (budget <= 100)
                {
                    double result = (budget * 30) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", result);
                }
                else if (budget > 100 && budget <= 1000)
                {
                    double result = (budget * 40) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", result);
                }
                else if (budget > 1000)
                {
                    double result = (budget * 90) / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", result);
                }
            }
        }
    }
}
