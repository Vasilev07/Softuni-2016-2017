using System;

class Program
{
    static void Main()
    {
        //input of the user
        byte n = byte.Parse(Console.ReadLine());

        //solutuion
        ushort years = (ushort)(n * 100);
        int days = (int)(years * 365.2422);
        int hours = (days * 24);
        long minutes = hours * 60;

        Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


    }
}

