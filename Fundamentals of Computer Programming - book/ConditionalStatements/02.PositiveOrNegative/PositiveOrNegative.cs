using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PositiveOrNegative
{
    class PositiveOrNegative
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum > 0)
            {
                Console.WriteLine("+");
            }
            else 
            {
                Console.WriteLine("-");
            }
            if (secondNum > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
            if (thirdNum > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
