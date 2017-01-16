using System;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*{0}*", new string('/', (n * 2) - 2));
                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*{0}*", new string('/', (n * 2) - 2));
                Console.WriteLine();
            }
            
            Console.Write(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
            Console.WriteLine();
        }
    }
}
