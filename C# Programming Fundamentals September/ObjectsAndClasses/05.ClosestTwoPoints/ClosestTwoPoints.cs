namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

                points.Add(new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                });
            }
           
            var minDistance = double.MaxValue;
            Point firstPointMaxDis = null;
            Point secondPointMaxDis = null;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstP = points[i];
                    var secondP = points[j];

                    var currentDistance = CalculateDistance(firstP, secondP);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMaxDis = firstP;
                        secondPointMaxDis = secondP;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMaxDis.X}, {firstPointMaxDis.Y})");
            Console.WriteLine($"({secondPointMaxDis.X}, {secondPointMaxDis.Y})");
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
