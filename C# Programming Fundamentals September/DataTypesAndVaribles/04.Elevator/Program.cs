using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main()
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            double courses = (people / capacity);
            Console.WriteLine(Math.Ceiling(courses));
            
        }
    }
}
