using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                 .Trim()
                 .Split('|')
                 .ToList();

            var result = new List<string>();
            result = list;
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));


        }
    }
}
