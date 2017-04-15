using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                }
            }
            else if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                    else if (secondArray[i] < firstArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                }
            }
        }
    }
}
