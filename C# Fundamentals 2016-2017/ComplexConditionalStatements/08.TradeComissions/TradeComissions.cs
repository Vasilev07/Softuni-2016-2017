using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal comission = -1.00M;
            if (city == "Sofia")
            {
                if (sales >=0  && sales <= 500)
                {
                    comission = sales * 0.05m;
                }
                else if(sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07m;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08m;
                }
                else if (sales > 10000 )
                {
                    comission = sales * 0.12m;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045m;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075m;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.1m;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13m;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055m;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08m;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12m;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145m;
                }
            }

            if (sales >=0 && (city == "Plovdiv" || city == "Varna" || city == "Sofia"))
            {
                Console.WriteLine($"{comission:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
