using System;


namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    if (y > 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

        }

    }
}
