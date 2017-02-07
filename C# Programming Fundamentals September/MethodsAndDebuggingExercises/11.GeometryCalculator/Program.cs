using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            string typeOfFigure = Console.ReadLine();
            if (typeOfFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                PrintingFormatedResult(TriangleArea(side, height));
            }
            else if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                PrintingFormatedResult(SquareArea(side));
            }
            else if (typeOfFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                PrintingFormatedResult(RectangleArea(width, height));
            }
            else if(typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                PrintingFormatedResult(CircleArea(radius));
            }
        }
        public static double TriangleArea(double side, double height)
        {
            var area = (side * height) / 2;
            return area;
        }
        public static double SquareArea(double side)
        {
            var area = (side * side);
            return area;
        }
        public static double RectangleArea(double width, double height)
        {
            var area = (width * height);
            return area;
        }
        public static double CircleArea(double radius)
        {
            var area = (radius * radius) * Math.PI;
            return area;
        }
        public static void PrintingFormatedResult(double area)
        {
            Console.WriteLine($"{area:F2}");
        }

    }
}
