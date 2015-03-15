/*Problem 3. Animal hierarchy

    Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
    Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ)
 * */

namespace AnimalHierarchy
{
    using System;
    class AnimalHierarchy
    {
        static void Main()
        {
            string[] names = new string[]
            {
                "CALVIN",
                "CALYPSO",
                "CALZE",
                "FANCY",
                "FANNY",
                "FANTASIA",
                "MADDIE",
                "MADEIRA",
                "MADISON",
                "MADMAX",
                "FROGY"
            };
            Random rand = new Random();

            Animal[] cats = new Cat[12];
            for (int i = 0; i < cats.Length; i++)
            {
                string name = names[rand.Next(0, 10)];
                uint age = (uint)rand.Next(1, 10);
                SexType sex = (SexType)rand.Next(1, 3);
                Cat cat = new Cat(name, age);
                cat.Sex = sex;
                cats[i] = cat;
            }
            cats[10] = new Kitten("Kity", 1);
            cats[11] = new Tomcat("Big", 3);

            uint catsAverageAge = Animal.CalculateAverageAge(cats);
            Console.WriteLine("Cats average age: {0}" , catsAverageAge);

            Animal[] frogs = new Frog[3];
            for (int i = 0; i < frogs.Length; i++)
            {
                string name = names[rand.Next(8, 11)];
                uint age = (uint)rand.Next(1, 5);
                SexType sex = (SexType)rand.Next(1, 3);
                Frog frog = new Frog(name, age);
                frog.Sex = sex;
                frogs[i] = frog;
            }

            Console.WriteLine("Frogs make sound");
            foreach (var frog in frogs)
            {
                frog.MakeSound();
                Console.WriteLine("Wait");
            }
        }
    }
}
