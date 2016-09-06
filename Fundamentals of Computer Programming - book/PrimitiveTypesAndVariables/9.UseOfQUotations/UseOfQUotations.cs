using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.UseOfQUotations
{
    class UseOfQUotations
    {
        static void Main(string[] args)
        {
            string firstUseOfQuotes = "The \"use\" of quotations causes difficulties.";
            string secondUseOfQuotes = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstUseOfQuotes);
            Console.WriteLine(secondUseOfQuotes);
        }
    }
}
