/*Problem 14. Extract students with two marks

    Write down a similar program that extracts the students with exactly two marks "2".
    Use extension methods.
*/

namespace _14.ExtractStudentsWithTwoMarks
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using _09.StudentGroups;

    static class ExtractStudentsWithTwoMarks
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
                for (int j = 0; j < rand.Next(1,4); j++)
                {
                    student.Marks.Add(rand.Next(3, 7));
                }
                students[i] = student;
            }

            var specialStudents = students.MarksCount(2);
            foreach (var st in specialStudents)
            {
                Console.WriteLine("{0} {1}, marks --> {2}", st.FirstName, st.LastName, string.Join(",", st.Marks));
            }
        }

        public static IEnumerable<Student> MarksCount(this IEnumerable<Student> students, int count)
        {
            List<Student> result = new List<Student>();
            foreach (var student in students)
            {
                if (student.Marks.Count == count)
                {
                    result.Add(student);
                }
            }
            return result.AsEnumerable();
        }
    }
}
