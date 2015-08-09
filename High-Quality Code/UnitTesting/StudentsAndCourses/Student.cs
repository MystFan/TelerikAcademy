namespace School
{
    using System;

    public class Student
    {
        private const int MinUniqueNumber = 10000;
        private const int MaxUniqueNumber = 99999;
        private string firstName;
        private string lastName;
        private int number;

        public Student(string firstName, string lastName, int uniqueNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = uniqueNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student first name can not be null");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Student first name can not be empty");
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

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student last name can not be null");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("student last name can not be empty");
                }

                this.lastName = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < Student.MinUniqueNumber || value > Student.MaxUniqueNumber)
                {
                    throw new ArgumentOutOfRangeException("Invalid student number");
                }

                this.number = value;
            }
        }
    }
}
