using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0; int takova = 0; bool toe = false;

        for (int i = 1; i <= n; i++)
        {


            takova = i;
            while (i > 0)
            {
                sum += i % 10;

                i = i / 10;
            }
            toe = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{takova} -> {toe}");
            sum = 0;
            i = takova;
        }
    }
}


