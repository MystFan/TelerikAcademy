using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string studentFirstName, string studentSLastName, int StudentAge)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentSLastName;
            this.Age = StudentAge;
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

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
    }
}
