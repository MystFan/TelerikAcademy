
namespace _04.PersonClass
{
    using System;
    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int? Age { get; private set; }

        public override string ToString()
        {
            string personAge = string.Format("{0}", this.Age != null ? " - age " + this.Age.ToString() : " - No age");
            string personString = this.Name + personAge;
            return personString;
        }
    }
}
