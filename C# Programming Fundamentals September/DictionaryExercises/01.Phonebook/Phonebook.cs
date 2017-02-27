namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var information = new Dictionary<string, string>();
            var holder = new List<string>();

            do
            {
                holder = Console.ReadLine()
                    .Split(' ').ToList();

                if (holder[0] == "A")
                {
                    information[holder[1]] = holder[2];
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
            } while (holder[0] != "END");
            
        }
    }
}
