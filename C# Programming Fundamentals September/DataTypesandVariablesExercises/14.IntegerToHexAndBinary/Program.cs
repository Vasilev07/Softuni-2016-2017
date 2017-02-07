using System;

    class Program
    {
        static void Main(string[] args)
        {
        var input = int.Parse(Console.ReadLine());
        var toHex = input.ToString("X");
        var toBin = Convert.ToString(input, 2);
        Console.WriteLine(toHex);
        Console.WriteLine(toBin);


        }
    }

