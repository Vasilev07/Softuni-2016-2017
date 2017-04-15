using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerТask
{
    public class MinerTask
    {
        public static void Main()
        {
            var information = new Dictionary<string, int>();
            var counter = 0;
            var resource = "";

            while (true)
            {
                var info = Console.ReadLine();
                counter++;
                var value = 0;
                if (info == "stop")
                {
                    break;
                }
                if (counter % 2 == 0)
                {
                    value = int.Parse(info);
                }
                else
                {
                    resource = info;
                }

                if (!information.ContainsKey(resource))
                {
                    information[resource] = 0;
                }
                else
                {
                    information[resource] += value;
                }
            }

            foreach (var item in information)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
