namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var information = new SortedDictionary<string, string>();
            var holder = Console.ReadLine()
                   .Split(' ').ToList();

            do
            {
                if (holder[0] == "A")
                {
                    information[holder[1]] = holder[2];
                }
                if (holder[0] == "ListAll")
                {
                    foreach (var item in information)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                if (holder[0] == "S")
                {

                    if (information.ContainsKey(holder[1]))
                    {
                        Console.WriteLine($"{holder[1]} -> {information[holder[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {holder[1]} does not exist.");
                    }

                }
                holder = Console.ReadLine()
                   .Split(' ').ToList();

            } while (holder[0] != "END");

        }
    }
}
