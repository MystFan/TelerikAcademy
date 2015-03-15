/*Problem 4. Age range

    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/

namespace _04.AgeRange
{
    using _03.FirstBeforeLast;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    class AgeRange
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

            var result = students.Where(s => s.Age >= 18 && s.Age <= 24).ToList();
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
