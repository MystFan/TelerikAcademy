using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Goshev";
            int age = 33;
            char gender = 'm';
            string id = "8306112507";
            string employeeNumber = "27561299";

            Console.WriteLine("Employee personal info");
            Console.WriteLine(new String('-',20));
            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            if (gender == 'm')
            {
                Console.WriteLine("Gender: male");
            }
            if (gender == 'f')
            {
                Console.WriteLine("Gender: fimale");
            }
            Console.WriteLine("Id: {0}",id);
            Console.WriteLine("Unique employee number: {0}",employeeNumber);
        }
    }
}
