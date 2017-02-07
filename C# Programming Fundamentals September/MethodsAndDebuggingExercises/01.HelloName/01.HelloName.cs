using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintName(name);
        } 
        static void PrintName()
        {
            Console.WriteLine($"Hello {name} !");
        }
    }
}
