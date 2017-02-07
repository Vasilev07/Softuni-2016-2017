using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloGreetingByName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + PrintName() + "!");
        }
        static string PrintName()
        {
            var name = Console.ReadLine();
            return name;

        }
    }
}

