using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ConcatenationOfStrings
{
    class ConcatenationOfStrings
    {
        static void Main(string[] args)
        {
            string csharp = "C#";
            string dotnet = ".NET";
            string cshacrpDotNet = csharp + dotnet;
            Console.WriteLine(cshacrpDotNet);
            string csharpDotNet5 = cshacrpDotNet + " " + 5;
            Console.WriteLine(csharpDotNet5);
        }
    }
}
