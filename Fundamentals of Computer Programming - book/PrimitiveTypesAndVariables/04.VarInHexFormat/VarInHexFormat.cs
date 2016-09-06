using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VarInHexFormat
{
    class VarInHexFormat
    {
        static void Main(string[] args)
        {
            int a = 256;
            string aInHex = a.ToString("X");
            Console.WriteLine("{0} \'a\' in bin ; \n {1} \'a\' in hex ", a, aInHex);
            

        }
    }
}
