using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double ages = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (ages < 16)
                {
                    Console.WriteLine("Miss");

                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (ages < 16)
                {
                    Console.WriteLine("Master");

                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
