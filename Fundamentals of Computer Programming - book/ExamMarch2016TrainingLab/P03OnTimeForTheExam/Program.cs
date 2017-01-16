using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minOfExam = int.Parse(Console.ReadLine());
            int hourOfArribing = int.Parse(Console.ReadLine());
            int minOfArriving = int.Parse(Console.ReadLine());
            int examInMin = (hourOfExam * 60) + minOfExam;
            int arrivingInMin = (hourOfArribing * 60) + minOfArriving;
            int holder = (examInMin - arrivingInMin);
            if (holder == 0)
            {
                Console.WriteLine("On Time");
            }
            else if (holder <= 30 && holder > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", holder);
            }
            else if (holder > 30)
            {
                if (holder > 30 && holder < 60)
                {
                     
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", holder);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", holder / 60, holder % 60);
                }
            }
            else if (holder < 0 && holder > -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", Math.Abs(holder));
            }
            else if (holder <= -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} hours after the start", Math.Abs(holder / 60), Math.Abs(holder % 60));
            }

        }
    }
}
