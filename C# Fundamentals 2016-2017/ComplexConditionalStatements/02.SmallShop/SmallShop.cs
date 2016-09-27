using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());
            decimal price = 0M;
            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    price = 0.5m * quantity;
                }
                else if (product == "water")
                {
                    price = 0.8m * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.2m * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.45m * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.6m * quantity;
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.4m * quantity;
                }
                else if (product == "water")
                {
                    price = 0.7m * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.15m * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.30m * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.5m * quantity;
                }
            }

            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    price = 0.45m * quantity;
                }
                else if (product == "water")
                {
                    price = 0.7m * quantity;
                }
                else if (product == "beer")
                {
                    price = 1.1m * quantity;
                }
                else if (product == "sweets")
                {
                    price = 1.35m * quantity;
                }
                else if (product == "peanuts")
                {
                    price = 1.55m * quantity;
                }
            }
            Console.WriteLine(price);
        }
    }
}
