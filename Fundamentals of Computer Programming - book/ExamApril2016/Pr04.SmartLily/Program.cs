using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04.SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washmachinePrice = double.Parse(Console.ReadLine());
            int priceOfToys = int.Parse(Console.ReadLine());
            int money = 0;
            int toys = 0;
            int result = 0;
            int counter = 0;
            int sum = 0;
            for (int i = 1; i <= lilysAge; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    money += 10;
                    sum += money;
                }
                else
                {
                    toys++;
                }
                result = (toys * priceOfToys) + sum - counter;
            } 

            
            if (result >= washmachinePrice)
            {
                Console.WriteLine("Yes! {0:F2}", result - washmachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", washmachinePrice - result);
            }
        }
    }
}
