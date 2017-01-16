using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;
            int yearsOfIvancho = 18;
            double moneyLeft = 0;
        

            for (int i = 1800; i <= year; i++, yearsOfIvancho++)
            {
                if (i % 2 == 0)
                {
                    moneyNeeded = 12000;
                    moneyLeft = inheritMoney - moneyNeeded;
                    inheritMoney = moneyLeft;
                }
                else
                {
                    moneyNeeded = 12000 + (yearsOfIvancho * 50);
                    moneyLeft = inheritMoney - moneyNeeded;
                    inheritMoney = moneyLeft;
                }
            }
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(moneyLeft));
            }
           
        }
    }
}
