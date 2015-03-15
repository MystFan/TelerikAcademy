
namespace SchoolClasses
{
    using System;
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;

        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name is too short");
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
            protected set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name is too short");
                }
                this.lastName = value;
            }
        }
    }
}
