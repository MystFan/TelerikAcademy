/*Problem 19. Grouped by GroupName extensions

    Rewrite the previous using extension methods.
*/
namespace _19.GroupedByGroupNameExtensions
{
    using System;
    using System.Collections.Generic;
    using _16.Groups;
    static class GroupedByGroupNameExtensions
    {
        static void Main()
        {
            Random rand = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Niki", "Doncho", "Pesho", "Maria", "Stamat", "Ivan", "Ivo", "Gosho", "Evlogi", "Svetlin" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov", "Goshev", "Hristov", "Nakov" };
            string[] departmentNames = new string[] { "Web development", "Mobile development", "Quality", "Mathematics" };

            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                Group gr = new Group(rand.Next(1, 7), departmentNames[rand.Next(0, 4)]);
                Student student = new Student(firstName, lastName, gr);
                students[i] = student;
            }

            var groupedStudents = students.GroupByDepartmentName();

            foreach (var group in groupedStudents)
            {
                foreach (var st in group)
                {
                    Console.WriteLine("{0} {1} --> {2}", st.FirstName, st.LastName, st.Group.DepartmentName);
                }
                Console.WriteLine("-------------------------------------------");
            }
        }

        public static IEnumerable<IEnumerable<Student>> GroupByDepartmentName(this IEnumerable<Student> students)
        {
            List<List<Student>> groups = new List<List<Student>>();
            List<string> departmentNames = new List<string>();
            foreach (var student in students)
            {
                if (!departmentNames.Contains(student.Group.DepartmentName))
                {
                    departmentNames.Add(student.Group.DepartmentName);
                }
            }

            for (int i = 0; i < departmentNames.Count; i++)
            {
                List<Student> list = new List<Student>();
                foreach (var student in students)
                {
                    if (student.Group.DepartmentName == departmentNames[i])
                    {
                        list.Add(student);
                    }
                }
                groups.Add(list);
            }

            return groups;
        }
    }
}
