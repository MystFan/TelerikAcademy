/*Problem 2. Students and workers

    Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
 *  Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
 *  Define the proper constructors and properties for this hierarchy.
    Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
    Initialize a list of 10 workers and sort them by money per hour in descending order.
    Merge the lists and sort them by first name and last name
 * */
namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    class StudentsAndWorkers
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
                uint grade = (uint)rand.Next(1, 5);
                Student student = new Student(firstName, lastName, grade);
                students[i] = student;
            }

            Console.WriteLine("STUDENTS");
            var studentsByGrade = students.OrderBy(st => st.Grade).ToList();
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine("{0} {1}, grade --> {2}", student.FirstName, student.LastName, student.Grade);
            }

            Worker[] workers = new Worker[10];
            for (int i = 0; i < workers.Length; i++)
            {
                string firstName = firstNames[rand.Next(0, 10)];
                string lastName = lastNames[rand.Next(0, 10)];
                decimal weekSalary = (decimal)rand.Next(100, 200);
                Worker worker = new Worker(firstName, lastName, weekSalary, 8);
                workers[i] = worker;
            }

            Console.WriteLine("WORKERS");
            var workersByHourMoney = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
            foreach (var worker in workersByHourMoney)
            {
                Console.WriteLine("{0} {1} --> {2} money per hour", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            var mergedList = students.Union<Human>(workers).OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            Console.WriteLine("HUMANS LIST");
            foreach (var human in mergedList)
            {
                string type = human.GetType().Name;
                Console.WriteLine("{0} {1} type --> {2}", human.FirstName, human.LastName, type);
            }
        }
    }
}
