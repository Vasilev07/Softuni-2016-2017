using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int weekendToHometown = int.Parse(Console.ReadLine());
            double gamesInSofia = (48 - weekendToHometown) * (3.0 / 4);
            double holydayGames = holydays * (2.0 / 3);
            double totalGamesInSofiaAndHolydays = gamesInSofia + holydayGames + weekendToHometown;
            double ifYearIsLeap = 0.0;
            double result = 0.0;
            if (typeOfYear == "leap")
            {
                ifYearIsLeap = totalGamesInSofiaAndHolydays * 0.15;
                result = ifYearIsLeap + totalGamesInSofiaAndHolydays;
            }
            else
            {
                result = totalGamesInSofiaAndHolydays * 1;
            }

            Console.WriteLine(($"{Math.Floor(result)}"));
        }
    }
}
