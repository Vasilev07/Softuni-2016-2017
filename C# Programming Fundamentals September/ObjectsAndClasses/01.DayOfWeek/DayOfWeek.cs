namespace _01.DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            var day = Console.ReadLine();
            var dateTime = DateTime.ParseExact(day, "d-M-yyyy", CultureInfo.InvariantCulture);

            var dayOfWeek = dateTime.DayOfWeek;

            Console.WriteLine(dayOfWeek);
        }
    }
}
