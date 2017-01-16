using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0.0;
        double avg = 0.0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }
        avg = (double)sum / (double)n;
        Console.WriteLine("min={0:f2}", min);
        Console.WriteLine("max={0:f2}", max);
        Console.WriteLine("sum={0:f2}", sum);
        Console.WriteLine("avg={0:f2}", avg);

    }
    
}

