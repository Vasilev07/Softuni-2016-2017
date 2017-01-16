using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var magic = int.Parse(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    for (int i3 = 0; i3 < 9; i3++)
                    {
                        for (int i4 = 0; i4 < 9; i4++)
                        {
                            for (int i5 = 0; i5 < 9; i5++)
                            {
                                for (int i6 = 0; i6 < 9; i6++)
                                {

                                    if (i * i2 * i3 * i4 * i5 * i6 == magic)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i,i2,i3,i4,i5,i6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
