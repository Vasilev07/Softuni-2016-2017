using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ErrorsInCalculatins
{
    class ErrorsInCalculatins
    {
        static void Main(string[] args)
        {
            float f = 0.1F;
            Console.WriteLine(f);
            double d = 0.1F; //incorrect
            Console.WriteLine(d);

            float ff = 1.0F / 3;
            Console.WriteLine(ff);
            double dd = ff;
            Console.WriteLine(dd); //incorrect
        }
    }
}
