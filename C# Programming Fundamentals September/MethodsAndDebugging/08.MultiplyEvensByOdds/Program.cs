using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvensAndOdds(number));
    }

    public static int GetMultipleOfEvensAndOdds(int number)
    {
        return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
    }

    public static int GetSumOfOddDigits(int number)
    {
        return SumOfDIgits(number, 1);
    }

    public static int GetSumOfEvenDigits(int number)
    {
        return SumOfDIgits(number, 0);
    }

    public static int SumOfDIgits(int number, int remainder)
    {
        var result = 0;
        foreach (var symbol in number.ToString())
        {
            var digit = symbol - '0';
            if (digit % 2 == remainder)
            {
                result += digit;
            }
        }
        return result;
    }
}

