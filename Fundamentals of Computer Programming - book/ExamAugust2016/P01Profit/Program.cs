using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workdaysInMonth = int.Parse(Console.ReadLine());
            var profitPerDay = double.Parse(Console.ReadLine());
            var dollarsInLev = double.Parse(Console.ReadLine());

            var monthSallarie = workdaysInMonth * profitPerDay;
            var yearSallarie = (monthSallarie*12) + (monthSallarie * 2.5);
            var sallarieWithTax = (yearSallarie * 25) / 100;
            var netProfit = (yearSallarie - sallarieWithTax) * dollarsInLev;
            var averageProfit = netProfit / 365;
            
            Console.WriteLine("{0:F2}",averageProfit);

            



        }
    }
}
