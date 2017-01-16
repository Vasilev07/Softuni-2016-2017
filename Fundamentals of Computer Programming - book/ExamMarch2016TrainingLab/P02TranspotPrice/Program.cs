using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02TranspotPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;
            if (kilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    price = (kilometers * 0.79) + 0.7;
                }
                else if (dayOrNight == "night")
                {
                    price = (kilometers * 0.9) + 0.7;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = (kilometers * 0.09);
            }
            else if (kilometers >= 100)
            {
                price = (kilometers * 0.06);
            }
            Console.WriteLine(price);
        }
    }
}
