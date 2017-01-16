using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int blanks = n - 1;
            //first part to n 
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}*",new string(' ', blanks));
                for (int c = 0; c < i-1; c++)
                {
                    Console.Write("-*");
                }
                blanks--;
                Console.WriteLine();
            }
            //second part from 0 to n - 1 
            blanks = 1;
            for (int i = n-1; i >= 1; i--)
            {
                Console.Write("{0}*", new string(' ', blanks));
                for (int c = i-1; c >= 1; c--)
                {
                    Console.Write("-*");
                }
                blanks++;
                Console.WriteLine();
            }
        }
    }
}
