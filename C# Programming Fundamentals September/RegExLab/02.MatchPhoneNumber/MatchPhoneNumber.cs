using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\+\d{3}(-|\s)\d{1}\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
