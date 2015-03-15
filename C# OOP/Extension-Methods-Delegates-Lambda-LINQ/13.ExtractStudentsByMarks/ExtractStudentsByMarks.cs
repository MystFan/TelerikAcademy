/*Problem 13. Extract students by marks

    Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
    Use LINQ.
*/

namespace _13.ExtractStudentsByMarks
{
    using System;
    using System.Linq;
    using _09.StudentGroups;
    class ExtractStudentsByMarks
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
                Student student = new Student(firstName, lastName);
                for (int j = 0; j < 5; j++)
                {
                    student.Marks.Add(rand.Next(3, 7));
                }
                students[i] = student;
            }

            var excellentStudents = students.Where(st => st.Marks.Contains(6)).Select(st => new { FullName = st.FirstName + " " + st.LastName, st.Marks });

            foreach (var st in excellentStudents)
            {
                Console.WriteLine("{0}, marks --> {1}", st.FullName, string.Join(",", st.Marks));
            }
        }
    }
}
