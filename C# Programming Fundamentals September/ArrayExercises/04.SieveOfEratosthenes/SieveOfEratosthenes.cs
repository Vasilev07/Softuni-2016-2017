

namespace _04.SieveOfEratosthenes
{
    using System;

    class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SieveOfEraFastWay(n);
        }

        public static void SieveOfEraFastWay(int n)
        {
            var primes = new bool[n + 1];


            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);

                    for (int j = 2; j <= n; j++)
                    {
                        if (j*i <=n && j*i >= 0)
                        {
                            primes[j * i] = false;
                        }
                    }
                }
            }

        }
    }
}
