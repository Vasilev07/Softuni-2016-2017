using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNum, secondNum));

        }
    }
}
