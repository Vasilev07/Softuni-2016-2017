using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Casting
{
    class Casting
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object concatenation = firstString + " " + secondString;
            string holderOfConcatenation = concatenation.ToString();
            Console.WriteLine(holderOfConcatenation);
        }
    }
}
