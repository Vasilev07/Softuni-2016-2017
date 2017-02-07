using System;



class Program
{
    static void Main(string[] args)
    {
        var firstNumber = double.Parse(Console.ReadLine());
        var secondNumber = double.Parse(Console.ReadLine());
        var comparingVar = Math.Abs(firstNumber-secondNumber);
        var eps = 0.000001;
        var areEqual = true;
        if (comparingVar <= eps)
        {
            Console.WriteLine(areEqual); 
        }
        else
        {
            Console.WriteLine($"{!areEqual}");
        }
    }
}

