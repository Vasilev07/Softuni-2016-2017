using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.LazyCatTom
{
    class LazyCatTom
    {
        static void Main(string[] args)
        {
            //if it is rest day 127 minutes play
            //if it is work day 63 minutes play
            //sleeping norm = 30 k minutes per year     
            int restDays = int.Parse(Console.ReadLine());
            int workDays = (365 - restDays);
            int workDaysPlay = workDays * 63;
            int restDaysPlay = restDays * 127;
            int totalPlay = workDaysPlay + restDaysPlay;
            int sleepingNorm = 30000;
            
            if (sleepingNorm > totalPlay)
            {
                int lessHours = (sleepingNorm - totalPlay) / 60;
                int lessMinutes = (sleepingNorm - totalPlay) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", lessHours, lessMinutes);
            }
            else if (sleepingNorm < totalPlay)
            {
                int moreHours = (totalPlay - sleepingNorm) / 60;
                int moreMinutes = (totalPlay - sleepingNorm) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", moreHours, moreMinutes);
            }

        }
    }
}
