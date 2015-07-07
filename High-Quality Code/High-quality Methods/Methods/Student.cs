namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.BirthDay;
            DateTime secondDate = other.BirthDay;
            return firstDate > secondDate;
        }
    }
}
