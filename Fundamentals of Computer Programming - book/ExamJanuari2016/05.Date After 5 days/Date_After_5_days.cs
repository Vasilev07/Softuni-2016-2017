using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_After_5_days
{
    class Date_After_5_days
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int afterFiveDays = day + 5;
            int maxMonthDays = 0;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
               maxMonthDays = 30;
            }
            else if (month == 2)
            {
                maxMonthDays = 28;
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                maxMonthDays = 31;
            }

            if (afterFiveDays > maxMonthDays)
            {
                afterFiveDays = afterFiveDays - maxMonthDays;
                month++;
                if (month > 12)
                {
                    month = 1;
                }
            }

            if (month < 10)
            {
                Console.WriteLine("{0}.0{1}", afterFiveDays, month);
            }
            else
            {
                Console.WriteLine("{0}.{1}", afterFiveDays, month);
            }
            
           
        }
    }
}
