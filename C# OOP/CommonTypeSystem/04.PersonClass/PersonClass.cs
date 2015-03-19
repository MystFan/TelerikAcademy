/*Problem 4. Person class

    Create a class Person with two fields – name and age. 
 * Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
    Write a program to test this functionality.
*/
namespace _04.PersonClass
{
    using System;
    class PersonClass
    {
        static void Main()
        {
            Person[] persons = new Person[]
            {
                new Person("Pesho Peshev", 19),
                new Person("Gosho Goshev", 20),
                new Person("Nikolai Kostov"),
                new Person("Svetlin Nakov"),
                new Person("Ivo Kenov"),
                new Person("Doncho Minkov"),
            };

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i]);
            }
        }
    }
}
