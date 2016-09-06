using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //declare some variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;
            //print them on the console
            Console.WriteLine(centuries + " centuries are " + years + " years, or" + days + "days, or" + hours + "hours." );

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);

        }
    }
}
