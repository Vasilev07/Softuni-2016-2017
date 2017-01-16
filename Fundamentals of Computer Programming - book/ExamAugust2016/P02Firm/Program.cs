using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var daysLeft = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            var learning = daysLeft - (daysLeft * 0.1);
            var realWork = learning * 8;
            var strangers = numberOfWorkers * 2 * daysLeft;
            var total = realWork + strangers;

            if (total >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(total - hoursNeeded));

            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(hoursNeeded - total));
            }

        }
    }
}
