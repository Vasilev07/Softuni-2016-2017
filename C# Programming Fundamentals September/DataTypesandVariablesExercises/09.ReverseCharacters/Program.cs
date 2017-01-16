using System;

class Program
{
    static void Main(string[] args)
    {
        var firstChar = char.Parse(Console.ReadLine());
        var secondChar = char.Parse(Console.ReadLine());
        var thirdChar = char.Parse(Console.ReadLine());

        char[] array1 = { firstChar, secondChar, thirdChar };
        Array.Reverse(array1);
        Console.WriteLine(array1);
       
    }
}

