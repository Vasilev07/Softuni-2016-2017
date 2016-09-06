using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Employees
{
    class Employees
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your gender \"m\" or \"f\": ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your unique employee number : ");
            int number = int.Parse(Console.ReadLine());


        }
    }
}
