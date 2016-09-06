using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Age
{
    class Age
    {
        static void Main(string[] args)
        {
            // write programm that reads your age from the console and prints your age after 10 years
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age + 10);
            int birthyear = int.Parse(Console.ReadLine());//year of our birth    ex.1996
            DateTime afrterTenYears = DateTime.Now.AddYears(10);//add 10 years from now
            int resultYears = afrterTenYears.Year - birthyear;// now + 10 years - birthyear(1996)  or 2016 + 10 - 1996
            Console.WriteLine(resultYears);

        }
    }
}
