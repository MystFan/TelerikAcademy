
namespace AnimalHierarchy
{
    using System;
    public class Kitten : Cat
    {
        public Kitten(string name, uint age)
            : base(name, age)
        {
            this.Sex = SexType.Fimale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mmmmmmmmay");
        }
    }
}
