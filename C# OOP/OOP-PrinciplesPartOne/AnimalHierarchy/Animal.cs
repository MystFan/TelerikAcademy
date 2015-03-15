
namespace AnimalHierarchy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public abstract class Animal : ISound
    {
        protected string name;
        protected uint age;

        protected Animal(string animalName, uint animalAge)
        {
            this.Name = animalName;
            this.Age = animalAge;
            this.Sex = SexType.None;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name is too short");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name is null or empty");
                }
                this.name = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid animal age");
                }
                this.age = value;
            }
        }

        public SexType Sex { get; set; }
        public static uint CalculateAverageAge(IEnumerable<Animal> animals)
        {
            uint sumOfAges = 0;
            foreach (var animal in animals)
            {
                sumOfAges += animal.Age;
            }
            uint averageAge = (uint)(sumOfAges / animals.Count());
            return averageAge;
        }

        public abstract void MakeSound();
    }
}
