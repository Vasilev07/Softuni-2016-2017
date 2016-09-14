using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            int companyFaxNumber = int.Parse(Console.ReadLine());
            string companyWebSite = Console.ReadLine();
            string companyManagerName = Console.ReadLine();
            string companyManagerSurname = Console.ReadLine();
            int companyManagerPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Company Name:{companyName}");
            Console.WriteLine("Company Address:{companyAddress}");
            Console.WriteLine("Company Phone Number:{companyPhoneNumber}");
            Console.WriteLine("Company Fax Number:{companyFaxNumber}");
            Console.WriteLine("Company WEB SITE:{companyWebSite}");
            Console.WriteLine("Company Manager First Name:{companyManagerName}");
            Console.WriteLine("Company Manager Surname:{companyManagerSurname}");
            Console.WriteLine("Company Manager Phone Number:{companyManagerPhone}");






        }
    }
}
