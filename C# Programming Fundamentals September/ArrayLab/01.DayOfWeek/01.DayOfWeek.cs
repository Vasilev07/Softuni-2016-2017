

namespace _01.DayOfWeek
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
       public static void Main()
        {
            var dayOfWeek = int.Parse(Console.ReadLine());
            var dayInEnglishHolder = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayOfWeek > 0 && dayOfWeek < 8)
            {
                Console.WriteLine(dayInEnglishHolder[dayOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
        
    }
}
