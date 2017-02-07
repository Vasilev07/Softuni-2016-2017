using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", secondArr), string.Join("", firstArr));
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", firstArr), string.Join("", secondArr));
            }
            else if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", secondArr), string.Join("", firstArr));
                        break;
                    }
                    else if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", firstArr), string.Join("", secondArr));
                        break;
                    }
                    else if (firstArr[i] == secondArr[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", secondArr), string.Join("", firstArr));
                        break;
                    }
                }
            }
        }
    }
}