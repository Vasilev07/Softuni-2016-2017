using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine().ToUpper();
            var matches = regex.Matches(input);
            var sb = new StringBuilder();

            foreach (Match mathc in matches)
            {
                var message = mathc.Groups[1].Value;
                var repeat = int.Parse(mathc.Groups[2].Value);
                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(message);
                }
              
            }

            Console.WriteLine("Unique symbols used: {0}", sb.ToString().Distinct().Count());
            Console.WriteLine(sb);
        }
    }
}
