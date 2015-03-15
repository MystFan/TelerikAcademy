using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int facultyNumber;
        private string phoneNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string studentFirstName, string studentSLastName)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentSLastName;
            this.Marks = new List<int>();
        }
        public Student(string studentFirstName, string studentSLastName, int fn)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentSLastName;
            this.FacultyNumber = fn;
            this.Marks = new List<int>();
        }
        public Student(string studentFirstName, string studentSLastName, int fn, int group)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentSLastName;
            this.FacultyNumber = fn;
            this.GroupNumber = group;
            this.Marks = new List<int>();
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

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid student faculty number");
                }
                this.facultyNumber = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value > 7 && value < 1)
                {
                    throw new ArgumentException("Student group number must be between 1 and 7");
                }
                this.groupNumber = value;
            }
        }
    }
}
