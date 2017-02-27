namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UsersLog
    {
        public static void Main()
        {
            var userIpCounts = new SortedDictionary<string, Dictionary<string, int>>();


            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                var name = input[input.Length - 1];
                var ip = input[1];

                if (!userIpCounts.ContainsKey(name))
                {
                    userIpCounts[name] = new Dictionary<string, int>();
                }

                if (!userIpCounts[name].ContainsKey(ip))
                {
                    userIpCounts[name][ip] = 0;
                }

                userIpCounts[name][ip]++;
            }

            foreach (var username in userIpCounts)
            {
                Console.WriteLine(username.Key + ":");
                var printing = new List<string>();
                foreach (var ip in username.Value)
                {
                    printing.Add(ip.Key + " => " + ip.Value);
                }
                Console.WriteLine("{0}.", string.Join(", ", printing));
            }
        }
    }
}
