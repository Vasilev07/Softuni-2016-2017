using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HeaderAndFooterOfSquare(n);
        PrintSquare(n);
        HeaderAndFooterOfSquare(n);

    }

    static void HeaderAndFooterOfSquare(int n)
    {
        var firstAndLastRow = (new string('-', n * 2));
        Console.WriteLine(firstAndLastRow);
    }

    static void PrintSquare(int n)
    {
        for (int i = 0; i < n-2; i++)
        {
            Console.Write("-");
            for (int j = 0; j < n-1; j++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");

            Console.WriteLine();
        }
    }
}
