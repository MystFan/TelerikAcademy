/*Problem 5. Order students

    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    Rewrite the same with LINQ.
*/

namespace _05.OrderStudents
{
    using System.Linq;
    using _03.FirstBeforeLast;
    using System.Collections.Generic;
    using System;
    class OrderStudents
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Doncho","Minkov",24),
                new Student("Niki","Kostov",23),
                new Student("Pesho","Peshev",27),
                new Student("Ivo","Kenov",25),
                new Student("Gas", "Monkey", 19)
            };

            var result = students.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName).ToList();
            Print(result);
        }

        private static void Print(List<Student> collection)
        {
            foreach (var st in collection)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }
        }
    }
}
