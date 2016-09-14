using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(area);
            }
            else if (typeOfFigure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine(area);
            }
            else if (typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine(area);
            }
            else if (typeOfFigure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightA = double.Parse(Console.ReadLine());
                double area = (sideA * heightA) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
