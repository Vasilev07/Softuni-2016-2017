namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public static void Main()
        {
            var firsPoint = Console.ReadLine().Split(' ');
            var first = new Point()
            {
                X = double.Parse(firsPoint[0]),
                Y = double.Parse(firsPoint[1])
            };

            var secondPoint = Console.ReadLine().Split(' ');

            var second = new Point()
            {
                X = double.Parse(secondPoint[0]),
                Y = double.Parse(secondPoint[1])
            };

            Console.WriteLine($"{CalculateDistance(first ,second):F3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var powX = Math.Pow(diffX, 2); 
            var powY = Math.Pow(diffY, 2);
            return Math.Sqrt(powX + powY);
        }
    }

}
