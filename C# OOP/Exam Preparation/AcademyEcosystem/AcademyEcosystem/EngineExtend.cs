using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class EngineExtend : Engine
    {
        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "wolf":
                    {
                        string name = commandWords[2];
                        Point location = Point.Parse(commandWords[3]);
                        Wolf wolf = new Wolf(name, location);
                        this.AddOrganism(wolf);
                        break;
                    }
                case "lion":
                    {
                        string name = commandWords[2];
                        Point location = Point.Parse(commandWords[3]);
                        Lion lion = new Lion(name, location);
                        this.AddOrganism(lion);
                        break;
                    }
                case "grass":
                    {
                        Point location = Point.Parse(commandWords[2]);
                        Grass grass = new Grass(location);
                        this.AddOrganism(grass);
                        break;
                    }
                case "boar":
                    {
                        string name = commandWords[2];
                        Point location = Point.Parse(commandWords[3]);
                        Boar boar = new Boar(name, location);
                        this.AddOrganism(boar);
                        break;
                    }
                case "zombie":
                    {
                        string name = commandWords[2];
                        Point location = Point.Parse(commandWords[3]);
                        Zombie zombie = new Zombie(name, location);
                        this.AddOrganism(zombie);
                        break;
                    }
                default: base.ExecuteBirthCommand(commandWords);
                    break;
            }
        }
    }
}
