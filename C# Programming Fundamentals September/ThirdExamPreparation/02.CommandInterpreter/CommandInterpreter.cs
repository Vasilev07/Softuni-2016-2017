using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var command = line
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string manipulation = command[0];
                switch (manipulation)
                {
                    case "reverse":
                        var reverseStart = int.Parse(command[2]);
                        var reverseCount = int.Parse(command[4]);
                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            array.Reverse(reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        var sortStart = int.Parse(command[2]);
                        var sortCount = int.Parse(command[4]);

                        if (IsValid(array, sortStart, sortCount))
                        {
                            array.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        var rollingLeftCount = int.Parse(command[1]);
                        if (rollingLeftCount >= 0)
                        {
                            RollingLeft(array, rollingLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        var rollingRightCount = int.Parse(command[1]);
                        if (rollingRightCount >= 0)
                        {
                            RollingRight(array, rollingRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
            }
            Console.WriteLine("[{0}]",string.Join(", ", array));

        }

        private static void RollingRight(List<string> array, int rollingRightCount)
        {
            rollingRightCount = rollingRightCount % array.Count;
            for (int i = 0; i < rollingRightCount; i++)
            {

                string lastElem = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);
                array.Insert(0, lastElem);
            }
        }

        private static void RollingLeft(List<string> array, int rollingLeftCount)
        {
            rollingLeftCount = rollingLeftCount % array.Count;
            for (int i = 0; i < rollingLeftCount; i++)
            {
                var firstElem = array[0];
                for (int j = 0; j < array.Count-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = firstElem;
            }
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            if (start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count)
            {
                return true;
            }
            return false;
        }

    }
}
