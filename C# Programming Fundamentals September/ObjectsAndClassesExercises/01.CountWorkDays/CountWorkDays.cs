namespace _01.CountWorkDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class CountWorkDays
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


            var holidays = new DateTime[]
            {
                    new DateTime(4, 01, 01),
                    new DateTime(4, 03, 03),
                    new DateTime(4, 05, 01),
                    new DateTime(4, 05, 06),
                    new DateTime(4, 05, 24),
                    new DateTime(4, 09, 06),
                    new DateTime(4, 09, 22),
                    new DateTime(4, 11, 01),
                    new DateTime(4, 12, 24),
                    new DateTime(4, 12, 25),
                    new DateTime(4, 12, 26)
            };

            var counter = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {

                var day = date.DayOfWeek;

                var temp = new DateTime(4, date.Month, date.Day);

                if (!holidays.Contains(temp) && !day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
