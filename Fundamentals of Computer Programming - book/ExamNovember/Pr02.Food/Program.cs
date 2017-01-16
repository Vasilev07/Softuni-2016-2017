using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02.Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());
            double totalFood = (days * foodForDog) + (days * foodForCat) + ((days * foodForTurtle)/1000);

            if (totalFood > food)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFood-food));
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - totalFood));
            }
        }
    }
}
