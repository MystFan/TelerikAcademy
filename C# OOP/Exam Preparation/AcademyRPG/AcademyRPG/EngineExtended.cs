using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class EngineExtended : Engine
    {
        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "knight":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Knight(name, position, owner));
                        break;
                    }
                case "giant":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Giant(name, position));
                        this.controllables.Add(new Giant(name, position));
                        break;
                    }
                case "rock":
                    {
                        Point position = Point.Parse(commandWords[3]);
                        int hitPoints = int.Parse(commandWords[2]);
                        Rock rock = new Rock(position, hitPoints);
                        this.AddObject(rock);
                        break;
                    }
                case "ninja":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        Ninja ninja = new Ninja(name, position, owner);
                        this.AddObject(ninja);
                        break;
                    }
                    //TODO case "house"
                default: base.ExecuteCreateObjectCommand(commandWords);
                    break;
            }
        }
    }
}
