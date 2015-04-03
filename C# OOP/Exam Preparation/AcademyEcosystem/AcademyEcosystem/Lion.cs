using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionSize = 6;
        public Lion(string name,Point location)
            : base(name, location, Lion.LionSize)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            int posibleEatAnimalSize = this.Size * 2;
            int eatenMeat = 0;
            if (animal != null)
            {
                if (animal.Size <= posibleEatAnimalSize)
                {
                    this.Size += 1;
                    eatenMeat = animal.GetMeatFromKillQuantity();
                }
            }
            return eatenMeat;
        }
    }
}
