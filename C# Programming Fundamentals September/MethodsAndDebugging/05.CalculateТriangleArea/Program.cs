using System;

class Program
{
    class ReturnTest
    {
        static double CalculateArea(double width, double height)
        {
            double area = (height * width) /2.0;
            return area;
        }

        static void Main()
        {
            double  width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = CalculateArea(width, height);
            Console.WriteLine(result);

            
        }
    }

}

