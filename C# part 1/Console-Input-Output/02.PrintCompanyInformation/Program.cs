using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 2. Print Company Information

//    -A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//    -Write a program that reads the information about a company and its manager and prints it back on the console.

namespace _02.PrintCompanyInformation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter company information");
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Web site: ");
            string url = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string inputAge = Console.ReadLine();
            byte age;
            bool isNumberAge = byte.TryParse(inputAge, out age);
            Console.Write("Manager phone number: ");
            string managerPhone = Console.ReadLine();

            string separator = "--------------------------------";
            Console.WriteLine(separator);
            Console.WriteLine("info".PadLeft((separator.Length - 4)/2));
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}" ,phone);
            Console.WriteLine("Fax: {0}" , fax);
            Console.WriteLine("Web site: {0}", url);
            if (isNumberAge)
            {
                Console.WriteLine("Manager: {0} {1}(age: {2},tel. {3})", managerFirstName, managerLastName, age, managerPhone);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
