using System;



    class Program
    {
        static void Main(string[] args)
        {
        string hexVar = Console.ReadLine();
        int deci = Convert.ToInt32(hexVar, 16);
        Console.WriteLine(deci);
        }
    }

