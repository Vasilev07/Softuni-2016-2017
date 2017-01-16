using System;
class Program
{
    static void Main(string[] args)
    {
        var centuries = int.Parse(Console.ReadLine());
        var years = centuries * 100;
        var days = (int)(Math.Ceiling((years * 365.24)));
        var hours = days * 24;
        var minutes = hours * 60;
        var seconds = (ulong)(minutes * 60);
        var miliseconds = (seconds * 1000);
        var microseconds = miliseconds * 1000;
        var nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {miliseconds} microseconds = {nanoseconds} nanoseconds");

    }
}

