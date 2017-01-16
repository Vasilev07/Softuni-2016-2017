using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string s = "";
            if (operation == '+')
            {
                result = firstNum + secondNum;
            }
            else if (operation == '-')
            {
                result = firstNum - secondNum;
            }
            else
            {
                result = firstNum * secondNum;
            }
            if (result % 2 == 0)
            {
                s = "even";
            }
            else
            {
                s = "odd";
            }
            if (operation == '/')
            {
                result = (firstNum / secondNum);
            }
            else if (operation == '%')
            {
                result = firstNum % secondNum;
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNum, operation, secondNum, result, s);
            }
            else
            {
                if (secondNum != 0)
                {
                    if (operation == '/')
                    {
                        Console.WriteLine("{0} {1} {2} = {3:F2}", firstNum, operation, secondNum, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", firstNum, operation, secondNum, result);
                    }
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNum);
                }

            }

        }
    }
}
