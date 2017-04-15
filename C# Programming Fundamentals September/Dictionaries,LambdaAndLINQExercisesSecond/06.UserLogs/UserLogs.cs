using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {

            var infoHolder = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var info = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                    
                if (info[0] == "End")
                {
                    break;
                }
                
                var user = info[info.Length-1];
                var ip = info[1];
                if (!infoHolder.ContainsKey(user))
                {
                    infoHolder[user] = new Dictionary<string, int>();
                }
                if (!infoHolder[user].ContainsKey(ip))
                {
                    infoHolder[user][ip] = 1;
                }
                else
                {
                    infoHolder[user][ip]++;
                }

            }
            foreach (var username in infoHolder)
            {
                Console.WriteLine($"{username.Key}:");
                var printingList = new List<string>();
                foreach (var items in username.Value)
                {
                    printingList.Add(items.Key + " => "  + items.Value);
                }
                Console.WriteLine(string.Join(", ", printingList));
            }
        }
    }
}
