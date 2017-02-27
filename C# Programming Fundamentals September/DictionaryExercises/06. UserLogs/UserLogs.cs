namespace _06.UserLogs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class UserLogs
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split('=', ' ');
                
                if (input[0] == "end")
                {
                    break;
                }
                var user = input[input.Length - 1];
                var ip = input[1];
                if (!dict.ContainsKey(user))
                {
                    dict[user] = new Dictionary<string, int>();
                }
                if (!dict[user].ContainsKey(ip))
                {
                    dict[user][ip] = 0;
                }
                dict[user][ip]++;
            }

        }
    }
}
