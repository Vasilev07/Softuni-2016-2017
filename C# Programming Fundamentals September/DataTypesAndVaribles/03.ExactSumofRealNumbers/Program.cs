using System;

class Program
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < userInput; i++)
        {
            decimal numbersFromUser = decimal.Parse(Console.ReadLine());
            sum += numbersFromUser;
        }
        Console.WriteLine(sum);
    }
}
