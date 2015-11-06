namespace _01.Students
{
    using System;

    public interface IStudent : IComparable
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        string CourseName { get; set; }
    }
}
