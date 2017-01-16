using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07.SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (n%i==0 && n % i2 == 0 && n % i3 == 0 && n % i4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, i2, i3, i4);
                            }
                        }
                    }
                }
            }
        }
    }
}
