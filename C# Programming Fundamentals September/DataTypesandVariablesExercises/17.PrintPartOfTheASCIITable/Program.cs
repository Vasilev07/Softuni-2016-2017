using System;

class Program
{
    static void Main(string[] args)
    {
        var startOfAscii = int.Parse(Console.ReadLine());
        var endOfAscii = int.Parse(Console.ReadLine());

        for (int i= startOfAscii;  i <= endOfAscii;  i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

