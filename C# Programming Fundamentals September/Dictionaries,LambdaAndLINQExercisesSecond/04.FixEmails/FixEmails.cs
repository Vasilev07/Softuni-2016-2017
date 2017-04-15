using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var information = new Dictionary<string, string>();
           
            while (true)
            {
                var name = Console.ReadLine();
                
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
                var ifContains = (email.Substring(email.Length - 2, 2));
                if (!information.ContainsKey(name))
                {
                    if (!(ifContains == "uk" || ifContains == "us"))
                    {
                        information[name] = email;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            foreach (var info in information)
            {
                Console.WriteLine($"{info.Key} -> {info.Value}");
            }
        }
    }
}
