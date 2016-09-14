using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            decimal kilometers = decimal.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            if (kilometers >= 20 && kilometers < 100 && (dayOrNight == "day" || dayOrNight =="night"))
            {
                kilometers *= 0.09M;
            }
            else if (kilometers >= 100 && (dayOrNight == "day" || dayOrNight == "night"))
            {
                kilometers *= 0.06M;
            }
            else if (kilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    kilometers *= 0.79M;
                    kilometers += 0.70M;
                }
                else if(dayOrNight == "night")
                {
                    kilometers *= 0.90M;
                    kilometers += 0.70M; 
                }
            }
            Console.WriteLine(kilometers);
        }
    }
}
