namespace _01.Students
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class CoursesDatabase
    {
        public readonly SortedDictionary<string, OrderedBag<IStudent>> Courses;

        public CoursesDatabase()
        {
            this.Courses = new SortedDictionary<string, OrderedBag<IStudent>>();
        }

        public void AddStudentByCourseName(IStudent student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("Parameter cannot be null.");
            }

            if (!this.Courses.ContainsKey(student.CourseName))
            {
                this.Courses[student.CourseName] = new OrderedBag<IStudent>();
            }

            this.Courses[student.CourseName].Add(student);
        }
    }
}
