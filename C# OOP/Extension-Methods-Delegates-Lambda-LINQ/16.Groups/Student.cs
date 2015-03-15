
namespace _16.Groups
{
    using System;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int groupNumber;
        private Group group;

        public Student(string studentFirstName, string studentSLastName, Group group)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentSLastName;
            this.Group = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Student first name is null");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Student last name is null");
                }
                this.lastName = value;
            }
        }

        public Group Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }
    }
}
