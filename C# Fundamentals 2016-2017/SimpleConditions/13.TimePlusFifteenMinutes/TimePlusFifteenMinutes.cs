using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TimePlusFifteenMinutes
{
    class TimePlusFifteenMinutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int inMinutes = (hours * 60) + minutes + 15;
            int resultHours = inMinutes / 60;
            int resultMinutes = inMinutes % 60;
           
            if (resultHours >= 24)
            {
                resultHours -= 24;
            }

            Console.WriteLine("{0}:{1:00}", resultHours, resultMinutes);

        }
    }
}
