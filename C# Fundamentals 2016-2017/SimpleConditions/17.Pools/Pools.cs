using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Pools
{
    class Pools
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int litersPerHourOne = int.Parse(Console.ReadLine());
            int litersPerHourTwo = int.Parse(Console.ReadLine());
            double hoursAbsence = double.Parse(Console.ReadLine());
            double firstTube = litersPerHourOne * hoursAbsence;
            double secondTube = litersPerHourTwo * hoursAbsence;
            double sumLiters = firstTube+ secondTube;
            double sumInPercent = (sumLiters / poolVolume) * 100;
            double firstInPercent = (firstTube / sumLiters) * 100;
            double secondInPercent = (secondTube / sumLiters) * 100;
            if (sumInPercent <= 100)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(sumInPercent), Math.Floor(firstInPercent), Math.Floor(secondInPercent));
            }
            else if (sumInPercent > 100)
            {
                double overflow = sumLiters - poolVolume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursAbsence, overflow);
            }
        }
    }
}
