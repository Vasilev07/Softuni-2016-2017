using System;


namespace fibonacciNumbers
{
    public class fibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                sum += temp;
            }
            Console.WriteLine(sum); 

        }

    }
}
