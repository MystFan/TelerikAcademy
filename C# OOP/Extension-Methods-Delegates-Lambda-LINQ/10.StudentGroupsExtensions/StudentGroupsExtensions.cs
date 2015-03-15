/*Problem 10. Student groups extensions

    Implement the previous using the same query expressed with extension methods.
*/
namespace _10.StudentGroupsExtensions
{
    using System;
    using _09.StudentGroups;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    class StudentGroupsExtensions
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
                int fn = rand.Next(100000, 999999);
                int groupNumber = rand.Next(1, 3);
                Student student = new Student(firstName, lastName, fn, groupNumber);
                students[i] = student;
            }

            
        }
    }

    static class Extensions
    {
        public static IEnumerable<Student> SortBy(this IEnumerable<Student> collection, Func<Student, bool> func)
        {
            foreach (var st in collection)
            {
                 func.Invoke(st);
            }
            return collection;
        }
    }
}
