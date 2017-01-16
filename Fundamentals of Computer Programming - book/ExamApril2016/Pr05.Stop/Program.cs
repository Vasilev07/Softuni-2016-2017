using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', (n*2) + 1));
            int points = n;
            int blanks = (n*2) - 1;
            int newBlanks = (n * 4) - 1;
            //top

            for (int i = 1; i <= n+1; i++)
            {
                if (i == (n + 1))
                {
                    Console.Write("{0}//{1}STOP!{1}\\\\{0}", new string('.', points), new string('_', (blanks-5)/2));
                }
                else
                {
                    Console.Write("{0}//{1}\\\\{0}", new string('.', points), new string('_', blanks));
                }
                points--;
                blanks += 2;
                Console.WriteLine();
            }
            
            points = 0;
          
            for (int i = n; i >= 1; i--)
            {
                
                Console.Write("{0}\\\\{1}//{0}", new string('.', points), new string('_', newBlanks));
                points++;
                newBlanks -= 2;
                Console.WriteLine();
            }
        }
    }
}
