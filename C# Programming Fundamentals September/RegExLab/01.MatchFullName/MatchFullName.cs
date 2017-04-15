using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    public class MatchFullName
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"[A-Z]{1}[a-z]{3,}\s[A-Z]{1}[a-z]{2,}";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
