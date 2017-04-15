using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var informationHolder = new SortedDictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine()
                    .Trim()
                    .Split(' ')
                    .ToList();
                var command = line[0];


                if (line[0] == "END")
                {
                    break;
                }

                if (command == "A")
                {
                    var phone = line[2];
                    var name = line[1];
                    if (!informationHolder.ContainsKey(name))
                    {
                        informationHolder[name] = phone;
                    }
                    else
                    {
                        informationHolder[name] = phone;
                    }
                }
                else if(command == "ListAll")
                {
                        foreach (var info in informationHolder)
                        {
                            Console.WriteLine($"{info.Key} -> {info.Value}");
                        }
                }
                else
                {
                    var name = line[1];

                    if (informationHolder.ContainsKey(name))
                    {
                        foreach (var person in informationHolder)
                        {
                            if (name == person.Key)
                            {
                                Console.WriteLine($"{person.Key} -> {person.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
