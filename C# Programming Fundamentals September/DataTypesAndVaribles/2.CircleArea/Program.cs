using System;


class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($"{area:F12}");
    }
}

