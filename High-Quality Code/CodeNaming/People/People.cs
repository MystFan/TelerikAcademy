////Refactor the following examples to produce code with well-named identifiers in C#://
////Task2//
namespace People
{
    using System;

    public class People
    {
        public enum Sex 
        { 
            male, fimale 
        }

        public static void Main()
        {
        }

        public void CreatePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.PersonName = "BigBrother";
                newPerson.Sex = Sex.male;
            }
            else
            {
                newPerson.PersonName = "TheChick";
                newPerson.Sex = Sex.fimale;
            }
        }

        private class Person
        {
            public Sex Sex { get; set; }

            public string PersonName { get; set; }

            public int Age { get; set; }
        }
    }
}
