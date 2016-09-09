using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.VegetablesAndFruits
{
    class VegetablesAndFruits
    {
        static void Main(string[] args)
        {
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int totalKilosOfVege = int.Parse(Console.ReadLine());
            int totalKilosOfFruits = int.Parse(Console.ReadLine());
            double totalCostOfVege = vegePrice * totalKilosOfVege;
            double totalCostOfFruits = fruitsPrice * totalKilosOfFruits;
            double totalSum = (totalCostOfVege + totalCostOfFruits) / 1.94D;
            Console.WriteLine(totalSum);
           

        }
    }
}
