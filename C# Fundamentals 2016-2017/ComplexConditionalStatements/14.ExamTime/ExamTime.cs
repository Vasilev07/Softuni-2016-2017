
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExamTime
{
    class ExamTime
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinute = int.Parse(Console.ReadLine());
            int examHourInMin = examHour * 60;
            int arrivingHourInMin = arrivingHour * 60;
            int totalMins = (examHourInMin + examMinute) - (arrivingHourInMin + arrivingMinute);
            if (totalMins <= 30 && totalMins > 0)
            {
                Console.WriteLine("On time {0} minutes before the start", totalMins);
            }
            else if (totalMins > 30)
            {
                Console.WriteLine("Early {0:00} minutes before the start", totalMins);
            }
            else if (totalMins < -59)
            {
                Console.WriteLine("Late {0:00} minutes after the start", Math.Abs(totalMins));
            }
            else if (totalMins == 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late {0:00} minutes after the start", Math.Abs(totalMins));
            }
        }
     }
}

