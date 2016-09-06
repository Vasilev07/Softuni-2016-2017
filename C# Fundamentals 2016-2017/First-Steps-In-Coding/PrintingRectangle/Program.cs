using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var n = int.Parse(Console.ReadLine());

        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= n; j++)
        //        {
        //            if ((i == 1 || i == n) || (j == 1 || j == n))
        //                Console.Write("*"); //prints at border place
        //            else
        //                Console.Write(" "); //prints inside other than border
        //        }
        //        Console.WriteLine();
        //    }

            var n = int.Parse(Console.ReadLine()); // Четем входа, интерпретираме го като цяло число(int) и го записваме в променливата n.
                                                ////
            var topAndBottom = new string('*', n); // Първо си правим един стринг, който ще служи както за капак, така и за дъно. По условие е широк n звездички.
            var middle = '*' + new string(' ', n - 2) + '*'; // Правим си средната част, която освен звездите, има и (n - 2) спейса. // (n -2) <-> (n минус звездичката отляво и тази отдясно).
            //// Top - Принтираме капака
            Console.WriteLine(topAndBottom);
            //// Middle - Принтираме средната част (n - 2) пъти. // Понеже целия квадрат трябва да има дължина и широчина n. (n на n) //Ако примерно n=5 -> 5 реда на 5 колони.
            //// Като извадим от n редът, който губим за капак и този за дъно, получаваме (n -2).
                for (int i = 0; i<n - 2; i++)
            {
                  Console.WriteLine(middle);
            }
            //// Bottom - Принтираме дъното
            Console.WriteLine(topAndBottom);
            
        }
    }
}
