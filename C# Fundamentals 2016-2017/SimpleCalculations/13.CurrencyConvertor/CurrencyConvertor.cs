using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main(string[] args)
        {
            
            double valueOfCurrency = double.Parse(Console.ReadLine());
            string currencyIn = Console.ReadLine();
            string currencyOut = Console.ReadLine();
            double result;
            
            //USD 1.79549
            //EUR 1.95583
            //GBP 2.53405
            if (currencyIn == "BGN")
            {
                if (currencyOut == "USD")
                {
                    result = valueOfCurrency / 1.79549D;
                    Console.WriteLine("{0:F2}",result);
                }
                else if (currencyOut == "EUR")
                {
                    result = valueOfCurrency / 1.95583D;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = valueOfCurrency / 2.53405D;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            else if (currencyIn == "USD")
            {
                if (currencyOut == "BGN")
                {
                    result = valueOfCurrency * 1.79549D;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (currencyOut == "EUR")
                {
                    result = valueOfCurrency * 1.79549D / 1.95583D;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = valueOfCurrency * 2.53405D / 1.79549D;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            else if (currencyIn == "EUR")
            {
                if (currencyOut == "BGN")
                {
                    result = valueOfCurrency * 1.95583D;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (currencyOut == "USD")
                {
                    result = valueOfCurrency * 1.95583D / 1.79549D;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = valueOfCurrency * 1.95583D / 2.53405D;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            else if (currencyIn == "GBP")
            {
                if (currencyOut == "BGN")
                {
                    result = valueOfCurrency * 2.53405D;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (currencyOut == "USD")
                {
                    result = valueOfCurrency * 2.53405D / 1.79549D;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = valueOfCurrency * 2.53405D / 1.95583D;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            
        }
    }
}
