/*Problem 12. Extract students by phone

    Extract all students with phones in Sofia.
    Use LINQ.
*/

namespace _12.ExtractStudentsByPhone
{
    using System;
    using System.Linq;
    using _09.StudentGroups;
    class ExtractStudentsByPhone
    {
        static void Main()
        {
            Random rand = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Niki", "Doncho", "Pesho", "Maria", "Stamat", "Ivan", "Ivo", "Gosho", "Evlogi", "Svetlin" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov", "Goshev", "Hristov", "Nakov" };

            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                string phoneNumber = "0" + rand.Next(2, 10) + rand.Next(100000, 999999);
                Student student = new Student(firstName, lastName);
                student.PhoneNumber = phoneNumber;
                students[i] = student;
            }

            Student[] studentsFromSofia = students.Where(st => st.PhoneNumber.StartsWith("02")).ToArray();

            foreach (var st in studentsFromSofia)
            {
                Console.WriteLine("{0} {1}, phone number {2}", st.FirstName, st.LastName, st.PhoneNumber);
            }
        }
    }
}
