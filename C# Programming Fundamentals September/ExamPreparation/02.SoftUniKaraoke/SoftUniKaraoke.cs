namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participant = Console.ReadLine()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var result = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();

            if (line == "dawn")
            {
                Console.WriteLine("No awards");
            }

            while (line != "dawn")
            {
                var performance = line.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

                var nameOfParticipant = performance[0];
                var song = performance[1];
                var award = performance[2];
               
                if (participant.Contains(nameOfParticipant) && !result.ContainsKey(nameOfParticipant) && songs.Contains(song))
                {
                    result[nameOfParticipant] = new List<string>();
                    result[nameOfParticipant].Add(award);
                }
                else
                {
                    if (participant.Contains(nameOfParticipant) && result.ContainsKey(nameOfParticipant) && songs.Contains(song))
                    {
                        if (!result[nameOfParticipant].Contains(award))
                        {
                            result[nameOfParticipant].Add(award);
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var part in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{part.Key}: {part.Value.Count} awards");

                foreach (var name in part.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"--{name}");
                }
            }
            
        }
    }
}
