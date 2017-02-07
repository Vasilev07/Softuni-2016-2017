using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeCheckInRange
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimes(start, end);

            Console.WriteLine(String.Join(", ", primes));
        }

        static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int currentNum = start; currentNum <= end; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }

        public static bool IsPrime(long a)
        {

          
            var isPrime = true;
            if (a == 0 || a == 1)
            {
                return !isPrime;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return !isPrime;
                    }
                }
                return isPrime;
            }

        }
    }
}
