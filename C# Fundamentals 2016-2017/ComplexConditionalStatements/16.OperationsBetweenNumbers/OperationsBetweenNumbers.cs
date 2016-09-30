using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0.0;
            if (operation == '+' || operation == '*' || operation == '-')
            {
                if (operation == '+')
                {

                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                }
                else if (operation == '*')
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                }
                else if (operation == '-')
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                }
            }
            else if (operation == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (operation == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
        
        }
    }
}
