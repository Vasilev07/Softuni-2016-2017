using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int lenght = numbers.Length;

        MaxIncreasingSequence(numbers, lenght);
    }

    public static void MaxIncreasingSequence(int[] numbers, int lenght)
    {
        int currentSequence = 0;
        int startCurrSeq = 0;
        int maxCounter = 0;
        int startMax = 0;

        for (int i = 1; i < lenght; i++)
        {
            if (numbers[i] - numbers[i - 1] >= 1)
            {
                currentSequence++;
                startCurrSeq = i - currentSequence;

                if (currentSequence > maxCounter)
                {
                    maxCounter = currentSequence;
                    startMax = startCurrSeq;
                }
            }
            else
            {
                currentSequence = 0;
            }
        }
        for (int i = startMax; i <= (startMax + startMax); i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}