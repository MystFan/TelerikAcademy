
namespace AnimalHierarchy
{
    using System;
    public class Cat : Animal
    {
        public Cat(string name, uint age)
            : base(name, age)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mayyyyyyyyyy");
        }
    }
}
