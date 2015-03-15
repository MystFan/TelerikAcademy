
namespace AnimalHierarchy
{
    using System;
    public class Dog : Animal
    {
        public Dog(string name, uint age)
            : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bauuuuuuuuuuuuuuuu!");
        }
    }
}
