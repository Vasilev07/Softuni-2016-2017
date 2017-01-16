using System;



class Program
{
    static void Main()
    {
        var counter = 1;
        var input = int.Parse(Console.ReadLine());
        for (int i = counter; i <= input; i++)
        {
            if ((i % 3 !=0) && (i % 7 !=0))
            {
                Console.Write(i + " ");
            }
           

        }
        Console.WriteLine();
    }
}

