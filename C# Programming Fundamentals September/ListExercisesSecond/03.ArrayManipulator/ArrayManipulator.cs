using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var currentRow = Console.ReadLine();
                if (currentRow == "print")
                {
                    break;
                }
                else
                {
                    var commandLine = currentRow
                        .Trim()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var command = commandLine[0];

                    switch (command)
                    {
                        case "add":
                            var index = int.Parse(commandLine[1]);
                            var element = int.Parse(commandLine[2]);
                            array.Insert(index, element);
                            break;
                        case "addMany":
                            var ind = int.Parse(commandLine[1]);
                            for (int i = 2, j = ind; i < commandLine.Count; i++, j++)
                            {
                                var current = int.Parse(commandLine[i]);
                                array.Insert(j, current);
                            }
                            break;
                        case "contains":
                            var el = int.Parse(commandLine[1]);
                            if (array.Contains(el))
                            {
                                Console.WriteLine(array.IndexOf(el));
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }
                            break;
                        case "remove":
                            var inde = int.Parse(commandLine[1]);
                            array.RemoveAt(inde);
                            break;
                        case "shift":
                            var position = int.Parse(commandLine[1]);
                            for (int i = 0; i < position; i++)
                            {
                                var arr = new List<int>();
                                arr.Add(array[i]);
                                array.InsertRange(array.Count, arr);
                                
                            }
                            array.RemoveRange(0, position);
                                break;
                        case "sumPairs":
                            for (int i = 0; i < array.Count-1; i++)
                            {
                                array[i] += array[i + 1];
                                array.Remove(array[i + 1]);
                            }
                            break;
                    }
                }
            }
                Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
