/*Problem 11. Extract students by email

    Extract all students that have email in abv.bg.
    Use string methods and LINQ.
*/

namespace _11.ExtractStudentsByEmail
{
    using System;
    using _09.StudentGroups;
    using System.Linq;
    class ExtractStudentsByEmail
    {
        static void Main()
        {
            Random rand = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Niki", "Doncho", "Pesho", "Maria", "Stamat", "Ivan", "Ivo", "Gosho", "Evlogi", "Svetlin" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov", "Goshev", "Hristov", "Nakov" };
            string[] emails = new string[] { "abv.bg", "yahoo.com", "gmail.com" };
            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                string email = firstName + lastName + "@" + emails[rand.Next(0, 3)];
                Student student = new Student(firstName, lastName);
                student.Email = email;
                students[i] = student;
            }

            Student[] studentsAbvEmails = students.Where(st => st.Email.IndexOf("abv.bg") >= 0).ToArray();

            foreach (var student in studentsAbvEmails)
            {
                Console.WriteLine("{0} {1}, email --> {2}", student.FirstName, student.LastName, student.Email);
            }
        }
    }
}
