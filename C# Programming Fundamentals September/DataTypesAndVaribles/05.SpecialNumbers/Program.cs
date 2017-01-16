using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        string tr = "";

        for (int i = 1; i <= n; i++)
        {
            sum = (i / 10) + (i % 10);
            if (sum == 5 || sum==7 || sum==11)
            {
                tr = "True";
            }
            else
            {
                tr = "False";
            }
            Console.WriteLine($"{i} -> {tr}");
        }
    }
}

