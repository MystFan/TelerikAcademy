/*Problem 16.* Groups

    Create a class Group with properties GroupNumber and DepartmentName.
    Introduce a property Group in the Student class.
    Extract all students from "Mathematics" department.
    Use the Join operator.
*/

namespace _16.Groups
{
    using System;
    using System.Linq;
    class Groups
    {
        static void Main()
        {
            Random rand = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Niki", "Doncho", "Pesho", "Maria", "Stamat", "Ivan", "Ivo", "Gosho", "Evlogi", "Svetlin" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov", "Goshev", "Hristov", "Nakov" };
            string[] departmentNames = new string[] {"Web development","Mobile development","Quality", "Mathematics"};

            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                Group gr = new Group(rand.Next(1, 7), departmentNames[rand.Next(0, 4)]);
                Student student = new Student(firstName, lastName, gr);
                students[i] = student;
            }

            var studentsFromDepartment = from st in students
                                         join departmentName in departmentNames on st.Group.DepartmentName equals departmentName
                                         where departmentName == "Mathematics"
                                         select new { st.FirstName, st.LastName, Department = departmentName };

            foreach (var student in studentsFromDepartment)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Department);
            }
        }
    }
}
