using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SecondExercise
{
    public class SecondExercise
    {
        public static void Main(string[] args)
        {
            var privateMessage = new Dictionary<string, List<string>>();
            var broadcast = new Dictionary<string, List<string>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Hornet is Green")
                {
                    break;
                }

                var querry = line
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var messagePattern = @"(\d+)\s(<->)\s([a-zA-Z0-9]+$)";
                var messageMatches = Regex.Match(line, messagePattern);

                var broadcastPattern = @"^(\D+)\s(<->)\s([a-zA-Z0-9]+$)";
                var broadcastmatches = Regex.Match(line, broadcastPattern);

                if (messageMatches.Success)
                {
                    var firstMatch = messageMatches.Groups[1].Value;
                    var secondMatch = messageMatches.Groups[3].Value;
                    if (!privateMessage.ContainsKey(firstMatch))
                    {
                        privateMessage[firstMatch] = new List<string>();
                    }
                    privateMessage[firstMatch].Add(secondMatch);
                }

                if (broadcastmatches.Success)
                {
                    var firstMatch = broadcastmatches.Groups[1].Value;
                    var secondMatch = broadcastmatches.Groups[3].Value;
                    if (!broadcast.ContainsKey(firstMatch))
                    {
                        broadcast[firstMatch] = new List<string>();
                    }
                    broadcast[firstMatch].Add(secondMatch);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcast)
                {
                    foreach (var s in item.Value)
                    {
                        s.Select(c => char.IsLetter(c) ? (char.IsUpper(c)) ? char.ToLower(c) : char.ToUpper(c) : c).ToList();
                        Console.WriteLine($"{s} -> {item.Key} ");
                    }

                }
            }
            Console.WriteLine("Messages:");
            if (privateMessage.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in privateMessage)
                {

                    var reversedKey = item.Key.ToCharArray();
                    string reverse = String.Empty;
                    for (int i = reversedKey.Length - 1; i > -1; i--)
                    {
                        reverse += reversedKey[i];
                    }

                    foreach (var s in item.Value)
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            char currentChar = s[i];
                            if (char.IsLower(currentChar))
                            {
                                currentChar.ToString().ToUpper();
                            }
                            else
                            {
                                currentChar.ToString().ToLower();
                            }
                        }
                        Console.WriteLine($"{reverse} -> {s}");
                    }
                }
            }
        }
    }
}
