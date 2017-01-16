using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05.FOx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            int dash = (2 * n) - 1;
            int mid = (n-1)/2;
            int mid2 = n;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.Write(new string('-', dash));
                Console.Write("/");
                Console.Write(new string('*', stars));
                stars++;
                dash -= 2;
                Console.WriteLine();
            }
            for (int i = 1; i <= (n/3); i++)
            {
                Console.Write("|");
                Console.Write(new string('*', mid));
                Console.Write("\\");
                Console.Write(new string('*', mid2));
                Console.Write("/");
                Console.Write(new string('*', mid));
                Console.Write("|");
                mid++;
                mid2 -= 2;
                Console.WriteLine();
            }

            int stars1 = 1;
            int dash1 = (2 * n) - 1;
            
           
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', stars1));
                Console.Write("\\");
                Console.Write(new string('*', dash1));
                Console.Write("/");
                Console.Write(new string('-', stars1));
                stars1++;
                dash1 -= 2;
                Console.WriteLine();
            }
        }
    }
}
