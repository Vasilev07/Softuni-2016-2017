using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Adventure
{
    class Adventure
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budjet <= 100)
            {
                if (season == "summer")
                {
                    double a = budjet * 0.3D;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", a);
                }
                else if(season == "winter")
                {
                    double a = budjet * 0.7D;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", a);
                }
            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    double a = budjet * 0.4D;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", a);
                }
                else if (season == "winter")
                {
                    double a = budjet * 0.8D;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", a);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", (budjet*0.9d));
            }
        }
    }
}
