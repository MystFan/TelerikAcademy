/*Problem 1. Student class

    Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
 *  Use an enumeration for the specialties, universities and faculties.
    Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

 Problem 2. IClonable

    Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

 * Problem 3. IComparable

    Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
 */
namespace _01.StudentClass
{
    using System;
    using System.Linq;
    class StudentClass
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
                string middleName = lastNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                long ssn = (long)rand.Next(111111111, 999999999) + 1000000000;
                Student student = new Student(firstName, middleName, lastName, ssn);
                students[i] = student;
            }

            SortArray(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        private static void SortArray<T>(T[] array) where T : IComparable
        {
            Array.Sort(array);
        }
    }
}
