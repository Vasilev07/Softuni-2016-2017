using System;

class Program
{
    static void Main(string[] args)
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        //perimeter
        var perimeter = (2 * width) + (2 * height);

        //area
        var area = width * height;

        //diagonal
        var diagonal = Math.Sqrt((width * width) + (height * height));

        //output
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);

    }
}

