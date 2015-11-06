namespace _01.Students
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            string filePath = "../../students.txt";
            IList<string> studentsEntities = ReadFile(filePath);
            Student[] students = ParseStudentEntities(studentsEntities);
            CoursesDatabase db = new CoursesDatabase();
            for (int i = 0; i < students.Length; i++)
            {
                db.AddStudentByCourseName(students[i]);
            }

            PrintStudents(db.Courses);
        }

        private static void PrintStudents(SortedDictionary<string, OrderedBag<IStudent>> courses)
        {
            foreach (var course in courses)
            {
                var courseStudents = course.Value.Select(s => s.FullName);
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", courseStudents));
            }
        }

        private static Student[] ParseStudentEntities(IList<string> studentsEntities)
        {
            Student[] students = new Student[studentsEntities.Count];
            for (int i = 0; i < studentsEntities.Count; i++)
            {
                string[] studentsEntitieParts = studentsEntities[i].Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
                students[i] = new Student
                {
                    FirstName = studentsEntitieParts[0].Trim(),
                    LastName = studentsEntitieParts[1].Trim(),
                    CourseName = studentsEntitieParts[2].Trim()
                };
            }

            return students;
        }

        private static IList<string> ReadFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            IList<string> entities = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    entities.Add(line);
                    line = reader.ReadLine();
                }
            }

            return entities;
        }
    }
}
