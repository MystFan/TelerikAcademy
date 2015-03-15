/*Problem 15. Extract marks

    Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
*/

namespace _15.ExtractMarks
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using _09.StudentGroups;
    class ExtractMarks
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
                int fn = int.Parse(rand.Next(1000, 9999).ToString() + "0" + rand.Next(1, 7));
                Student student = new Student(firstName, lastName, fn);
                for (int j = 0; j < 6; j++)
                {
                    student.Marks.Add(rand.Next(3, 7));
                }
                students[i] = student;
            }

            var studentsMarks = students.Where(st => st.FacultyNumber % 100 == 6).Select(st => new { fn = st.FacultyNumber, st.Marks }).ToList();

            foreach (var student in studentsMarks)
            {
                Console.WriteLine("fn-{0}, marks-{1}",student.fn, string.Join(",",student.Marks));
            }
        }
    }
}
