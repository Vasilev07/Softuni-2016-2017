using System;
class Program
{
    static void Main(string[] args)
    {
        var centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;
        decimal seconds = (decimal)minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries:F0} centuries = {years:F0} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes = {seconds:F0} seconds = {milliseconds:F0} milliseconds = {microseconds:F0} microseconds = {nanoseconds:F0} nanoseconds");
    }
}

