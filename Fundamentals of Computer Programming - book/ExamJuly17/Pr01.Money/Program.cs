using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            double dollar = 1.76D;
            double euro = 1.95D;
            
            double bitInLv = (bitcoin*1168D);
            double chinaInLv = ((china*0.15D)*dollar);
            double allInEuro = (bitInLv + chinaInLv) / euro;
            double result = allInEuro - (allInEuro * (commision/100));
            Console.WriteLine(result);



        }
    }
}
