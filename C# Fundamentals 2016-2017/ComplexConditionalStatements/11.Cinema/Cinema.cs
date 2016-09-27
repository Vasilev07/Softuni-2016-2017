using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double result = 0.0;
            if (typeOfProjection == "Premiere")
            {
                result = row * col * 12.0;
            }
            else if (typeOfProjection == "Normal")
            {
                result = row * col * 7.5;
            }
            else
            {
                result = row * col * 5.00;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
