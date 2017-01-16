using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UserChoice
{
    class UserChoice
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            switch (x)
            {
                case "int":
                    int i = int.Parse(Console.ReadLine());
                    i = i + 1;
                    Console.WriteLine(i); break;
                case "double":
                    double d = double.Parse(Console.ReadLine());
                    d = d + 1;
                    Console.WriteLine(d); break;
                case "string":
                    string s = Console.ReadLine();
                    Console.WriteLine(s + "*"); break;
                default:; break;
            }

        }
    }
}
