using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01.Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumria = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double pricePalamud = (skumria + (skumria * 0.6)) * palamudKg;
            double priceSafrid = (caca + (caca * 0.8)) * safridKg;
            double priceMidi = midiKg * 7.5;
            double totalPrice = priceMidi + pricePalamud + priceSafrid;
            Console.WriteLine("{0:F2}",totalPrice);

        }
    }
}
