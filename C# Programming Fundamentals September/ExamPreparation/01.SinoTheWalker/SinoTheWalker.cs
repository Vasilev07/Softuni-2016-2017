namespace _01.SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            var totalSecondsForStep = (ulong)steps * (ulong)secondsPerStep;

            var leavingInSeconds = leavingTime.Hour * 60 * 60 + leavingTime.Minute * 60 + leavingTime.Second;
            ulong totalSeconds = (ulong)leavingInSeconds +  totalSecondsForStep;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHour = totalMinutes / 60;
            var hours = totalHour % 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");

        }
    }
}
