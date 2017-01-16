using System;



class Program
{
    static void Main(string[] args)
    {
        string first = "Hello";
        string second = "World";
        object concat = first + " " + second;
        string finalConcat = Convert.ToString(concat);
        Console.WriteLine(finalConcat);

    }
}

