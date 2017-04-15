using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {   
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var daysOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (input >= 1 && input <=7 )
            {
                Console.WriteLine(string.Join("", daysOfWeek[input - 1]));
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
