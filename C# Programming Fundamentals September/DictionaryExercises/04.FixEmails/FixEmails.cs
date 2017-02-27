namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var dict = new Dictionary<string, string>();
          

            while (true)
            {
                var input = Console.ReadLine();
                
                if (input == "stop")
                {
                    break;
                }
                var mail = Console.ReadLine();
                var ifContains = (mail.Substring(mail.Length - 2, 2));
                if (!dict.ContainsKey(input))
                {
                    if (!(ifContains == "uk" || ifContains == "us"))
                    {
                        dict[input] = mail;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
