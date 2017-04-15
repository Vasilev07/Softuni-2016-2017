namespace ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input!="end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern,replace);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }

        }
    }
}
