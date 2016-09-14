using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double bonuspoints = 0.0;
            if (a <= 100)
            {
                bonuspoints = 5;
            }
            else if (a > 100 && a <= 1000)
            {
                bonuspoints = a * 0.2D;
            }
            else if (a > 1000)
            {
                bonuspoints= a * 0.1D;

            }

            if (a % 2 == 0)
            {
                bonuspoints += 1;

            }
            if (a % 10 == 5)
            {
                bonuspoints += 2;

            }

            Console.WriteLine(bonuspoints);
            Console.WriteLine(bonuspoints + a);
        }
    }
}
