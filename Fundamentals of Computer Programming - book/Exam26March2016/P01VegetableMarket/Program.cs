using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegeKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());
            double priceInEuro = ((vegePrice * vegeKg) + (fruitPrice * fruitKg)) / 1.94;
            Console.WriteLine(priceInEuro);
        }
    }
}
//    Console.Write("{0}/ \\{0}", new string('*', n - 2));
//    Console.Write("{0}/ \\{0}", new string('*', n - 2));