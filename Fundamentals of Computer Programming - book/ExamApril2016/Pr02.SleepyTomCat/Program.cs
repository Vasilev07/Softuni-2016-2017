using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int gameInRestDays = restDays * 127;
            int gameInWorkDays = workDays * 63;
            int sum = gameInRestDays + gameInWorkDays;
            int cap = 30000;
            int result = 0;
            if (cap > sum)
            {
                result = cap - sum;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", result/60, result % 60);
            }
            else
            {
                result = sum - cap;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", result / 60, result % 60);
            }
        }
    }
}
