using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n == 0 || n == 1)
            {
                isPrime = false;

            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }



        }
    }
}