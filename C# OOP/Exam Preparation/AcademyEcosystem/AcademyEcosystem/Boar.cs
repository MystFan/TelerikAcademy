using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BoarSize = 6;
        private const int BiteSize = 2;
        public Boar(string name, Point location)
            : base(name, location, Boar.BoarSize)
        {
            
        }
        public int TryEatAnimal(Animal animal)
        {
            int eatenMeat = 0;
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    eatenMeat = animal.GetMeatFromKillQuantity();
                }
            }
            return eatenMeat;
        }

        public int EatPlant(Plant plant)
        {
            int eatenPlant = 0;
            if (plant != null)
            {
                eatenPlant = plant.GetEatenQuantity(Boar.BiteSize);
                this.Size++;
            }
            return eatenPlant;
        }
    }
}
