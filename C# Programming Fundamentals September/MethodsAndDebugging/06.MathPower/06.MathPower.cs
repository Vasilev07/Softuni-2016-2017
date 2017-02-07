using System;


namespace _06.MathPower
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number, power));
        }
        static double MathPower(double number, double power)
        {
            var numberOnPower = Math.Pow(number, power);
            return numberOnPower;
        }
    }
}
