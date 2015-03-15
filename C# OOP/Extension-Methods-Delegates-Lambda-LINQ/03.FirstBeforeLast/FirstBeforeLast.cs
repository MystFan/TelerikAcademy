/*Problem 3. First before last

    Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    Use LINQ query operators.
*/

namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;
    class FirstBeforeLast
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Doncho","Minkov",24),
                new Student("Niki","Kostov",23),
                new Student("Pesho","Peshev",27),
                new Student("Ivo","Kenov",25)
            };

            Student[] orderByNameStudents = SortStudentNames(students);
            foreach (var student in orderByNameStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        private static Student[] SortStudentNames(Student[] students)
        {
            Student[] sortedArray = students.Where(s => string.Compare(s.FirstName, s.LastName) < 0).ToArray();
            return sortedArray;
        }
    }
}
