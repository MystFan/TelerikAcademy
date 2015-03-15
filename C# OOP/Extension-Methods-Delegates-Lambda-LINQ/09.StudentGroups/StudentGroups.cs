/*Problem 9. Student groups

    Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    Create a List<Student> with sample students. Select only the students that are from group number 2.
    Use LINQ query. Order the students by FirstName.
*/

namespace _09.StudentGroups
{
    using System;
    using System.Linq;
    class StudentGroups
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Niki", "Doncho", "Pesho", "Maria", "Stamat", "Ivan", "Ivo", "Gosho", "Evlogi", "Svetlin" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov", "Goshev", "Hristov", "Nakov" };
            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                int fn = rand.Next(100000, 999999);
                int groupNumber = rand.Next(1, 3);
                Student student = new Student(firstName, lastName, fn, groupNumber);
                students[i] = student;
            }

            Student[] results = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).ToArray();
            foreach (var st in results)
            {
                Console.WriteLine("{0} {1}, fak number - {2}, group - {3}", st.FirstName, st.LastName, st.FacultyNumber, st.GroupNumber);
            }
        }
    }
}
