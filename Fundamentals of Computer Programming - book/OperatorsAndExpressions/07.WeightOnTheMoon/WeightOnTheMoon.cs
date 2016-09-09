using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WeightOnTheMoon
{
    class WeightOnTheMoon
    {
        static void Main(string[] args)
        {
            int earthWeight = int.Parse(Console.ReadLine());
            int moonWeight = earthWeight * 17 / 100;
            Console.WriteLine(moonWeight);
        }
    }
}
