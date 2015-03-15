/* Problem 18. Grouped by GroupName

    Create a program that extracts all students grouped by GroupName and then prints them to the console.
    Use LINQ.
*/
namespace _18.GroupedByGroupName
{
    using System;
    using System.Linq;
    using _16.Groups;
    class GroupedByGroupName
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

            var groupedStudents = students.GroupBy(st => st.Group.DepartmentName);

            foreach (var group in groupedStudents)
            {
                foreach (var st in group)
                {
                    Console.WriteLine("{0} {1} --> {2}", st.FirstName, st.LastName, st.Group.DepartmentName);
                }
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
