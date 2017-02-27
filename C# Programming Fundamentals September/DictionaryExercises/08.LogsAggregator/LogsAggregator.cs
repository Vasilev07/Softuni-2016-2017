namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var userInfo = new Dictionary<string, SortedList<string, int>>();

            for (int i = 0; i < rows; i++)
            {
                var currentLog = Console.ReadLine()
                    .Split(' ');

                var ip = currentLog[0];
                var user = currentLog[1];
                var time = currentLog[2];


                if (!userInfo.ContainsKey(user))
                {
                    userInfo[user] = new SortedList<string, int>();
                }
                if (!userInfo[user].ContainsKey(ip))
                {
                    userInfo[user][ip] = int.Parse(time);
                }
                else
                {
                    userInfo[user][ip] += int.Parse(time);
                }
            }
            var timeHolder = 0;
            var ipHolder = "";
            foreach (var item in userInfo)
            {
                var last = item.Value.LongCount();
                Console.Write($"{item.Key}: ");

                foreach (var ip in item.Value)
                {
                    if (last - 1== 0)
                    {
                        ipHolder += ip.Key;
                    }
                    else
                    {
                        ipHolder += ip.Key + ", ";
                    }

                    timeHolder += ip.Value;
                    last--;
                }
                Console.WriteLine($"{timeHolder} [{ipHolder}]");

                timeHolder = 0;
                ipHolder = "";
            }
        }
    }
}
