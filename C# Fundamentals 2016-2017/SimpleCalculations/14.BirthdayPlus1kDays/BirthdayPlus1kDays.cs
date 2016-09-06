using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BirthdayPlus1kDays
{
    class BirthdayPlus1kDays
    {
        static void Main(string[] args)
        {
            var birthDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.WriteLine(birthDay.AddDays(999).ToString("dd-MM-yyyy"));


        }
    }
}
