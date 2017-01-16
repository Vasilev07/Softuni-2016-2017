using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05.Diamon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var beggining = n - 1;
            var points = 3*n;
            
            Console.Write(new string('.', n));
            Console.Write(new string('*', 3 * n));
            Console.Write(new string('.', n));
            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.', beggining));
                Console.Write('*');
                Console.Write(new string('.', points));
                Console.Write('*');
                Console.Write(new string('.', beggining));
                beggining--;
                points += 2;
                Console.WriteLine();
            }
            Console.Write(new string('*', 5 * n));
            Console.WriteLine();
            beggining = 1;
            points = 5 * n - 4;
            for (int i = 0; i < 2*n; i++)
            {
               Console.Write(new string('.', beggining));
               Console.Write('*');
               Console.Write(new string('.', points));
               Console.Write('*');
               Console.Write(new string('.', beggining));
               beggining += 1;
               points -= 2;
               Console.WriteLine();
            }
            
            Console.Write(new string('.', n*2+1));
            Console.Write(new string('*', n-2));
            Console.Write(new string('.', n*2+1));
            Console.WriteLine();
        }
    }   
}
