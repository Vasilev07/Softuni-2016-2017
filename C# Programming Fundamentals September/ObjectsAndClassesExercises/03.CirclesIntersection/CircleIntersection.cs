namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;
    public class CircleIntersection
    {
        public static void Main()
        {
            var firstCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstCircleInfo = new Circle()
            {
                X = firstCircle[0],
                Y = firstCircle[1],
                R = firstCircle[2]
            };


            var secondCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondCircleInfo = new Circle()
            {
                X = secondCircle[0],
                Y = secondCircle[1],
                R = secondCircle[2]
            };

            if (Intersect(firstCircleInfo, secondCircleInfo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle firstCircleInfo, Circle secondCircleInfo)
        {
            
            var distance = Math.Sqrt((Math.Pow((firstCircleInfo.X - secondCircleInfo.X), 2) +
                Math.Pow((firstCircleInfo.Y - secondCircleInfo.Y), 2)));
            var radiusSum = firstCircleInfo.R + secondCircleInfo.R;
            if (!(distance <= radiusSum))
            {
                return false;
            }
           return true;
        }
    }
}
