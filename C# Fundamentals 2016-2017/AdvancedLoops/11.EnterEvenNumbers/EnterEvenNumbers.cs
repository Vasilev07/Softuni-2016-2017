using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumbers
{
    class EnterEvenNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {

                    Console.WriteLine("Enter even number:");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        break;

                    }

                    Console.WriteLine("The number is not even");
                }

                catch
                {
                    Console.WriteLine("Invalid number!");

                }
            }
        }
    }
}
