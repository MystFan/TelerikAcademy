namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        private const int MaxStudentsCount = 30;
        private string title;
        private List<Student> students;

        public Course(string title)
        {
            this.Title = title;
            this.Students = new List<Student>();
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Course title can not be null");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Course title can not be empty");
                }

                this.title = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students collection can not be null");
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to add can not be null");
            }

            if (this.students.Count >= Course.MaxStudentsCount)
            {
                throw new ArgumentException(string.Format("Course can not add more than {0} students", Course.MaxStudentsCount));
            }

            if (this.students.Any(st => st.Number == student.Number))
            {
                throw new ArgumentException("Course alredy have students with same number");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to remove can not be null");
            }

            if (!this.students.Any(st => st.Equals(student)))
            {
                throw new ArgumentException("Course not contains such student");
            }

            this.students.Remove(student);
        }
    }
}
