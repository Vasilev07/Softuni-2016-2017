
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
            int totalExamMinutes = (examHour * 60) + examMinute;
            int totalArrivingMinutes = (arrivingHour * 60) + arrivingMinute;
            if (totalExamMinutes == totalArrivingMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (totalExamMinutes > totalArrivingMinutes)
            {
                int totalTime = totalExamMinutes - totalArrivingMinutes;
                if (totalTime <= 30)
                {
                    Console.WriteLine("On time {0} minutes before the start", totalTime);
                }
                else if (totalTime > 30 && totalTime < 60)
                {
                    Console.WriteLine("Early {0} minutes before the start ", totalTime);
                }
                else
                {
                    int hh = totalTime / 60;
                    int mm = totalTime % 60;
                    Console.WriteLine("Early {0}:{1:00} hours before the start", hh, mm);
                }
            }
            else
            {
                int totalTime = totalArrivingMinutes - totalExamMinutes;
                
                if (totalTime < 60)
                {
                    Console.WriteLine("Late {0} minutes after the start ",totalTime);
                }
                else
                {
                    int hh = totalTime / 60;
                    int mm = totalTime % 60;
                    Console.WriteLine("Late {0}:{1:00} hours after the start", hh, mm);
                }
            }
        }
    }
}


