namespace _01.CountWorkDays
{
    using System;
    using System.Globalization;

    public class CountWorkDays
    {
        public static void Main()
        {
            var startDate = new Date()
            {
                StartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy ",
            CultureInfo.InvariantCulture)
            };

            var endDate = new Date()
            {
                EndDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy ",
            CultureInfo.InvariantCulture)
            };

            var holidays = new DateTime[]
            {
                 new DateTime(01-01),
                 new DateTime(03-03),
                 new DateTime(01-05),
                 new DateTime(06-05),
                 new DateTime(24-05),
                 new DateTime(06-09),
                 new DateTime(22-09),
                 new DateTime(01-11),
                 new DateTime(24-12),
                 new DateTime(25-12),
                 new DateTime(26-12)
            };

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {

            }

        }
    }
}
