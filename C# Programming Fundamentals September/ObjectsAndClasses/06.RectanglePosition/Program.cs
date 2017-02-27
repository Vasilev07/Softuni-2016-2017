namespace _06.RectanglePosition
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstRect = new RectanglePosition
            {
                Left = firstInput[0],
                Top = firstInput[1],
                Width = firstInput[2],
                Height = firstInput[3]
            };

            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var secondRect = new RectanglePosition
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };
          
            if (IsInside(firstRect, secondRect))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

        public bool IsInside(RectanglePosition r, RectanglePosition b)
        {
            return (r.Left <= b.Left) && (r.Right >= b.Right) && (r.Top <= b.Top) && (r.Bottom >= b.Bottom);
        }
    }
}
