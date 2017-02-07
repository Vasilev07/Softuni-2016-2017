using System;


class Program
{
    public static void Main()
    {
        var sideOfSquare = double.Parse(Console.ReadLine());
        var kindOfSide = Console.ReadLine();

        Square(sideOfSquare, kindOfSide);
    }

    public static void Square(double side, string kind)
    {
        if (kind == "face")
        {
            double faceDiagonal = Math.Sqrt(2*(side * side));
            Console.WriteLine($"{faceDiagonal:F2}");
        }
        else if(kind == "space")
        {
            double spaceDiagonal = Math.Sqrt(3 * (side * side));
            Console.WriteLine($"{spaceDiagonal:F2}");
        }
        else if (kind == "volume")
        {
            double volume = side * side * side;
            Console.WriteLine($"{volume:F2}");
        }
        else if (kind == "area")
        {
            double area = 6 * (side * side);
            Console.WriteLine($"{area:F2}");
        }
    }  
}

