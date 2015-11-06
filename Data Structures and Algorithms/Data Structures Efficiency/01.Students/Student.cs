namespace _01.Students
{
    using System;

    public class Student : IStudent, IComparable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CourseName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public int CompareTo(object other)
        {
            var otherStudent = other as Student;
            return this.FullName.CompareTo(otherStudent.FullName);
        }
    }
}
