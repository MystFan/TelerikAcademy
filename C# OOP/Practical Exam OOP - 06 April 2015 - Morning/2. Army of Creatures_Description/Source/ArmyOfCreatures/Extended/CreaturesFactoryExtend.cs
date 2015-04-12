
namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Creatures;
    using System;
    public class CreaturesFactoryExtend : CreaturesFactory
    {
        public override Logic.Creatures.Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "WolfRaider":
                    return new WolfRaider();
                case "Goblin":
                    return new Goblin();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Griffin":
                    return new Griffin();
                default:
                    return base.CreateCreature(name);
            }
        }
    }
}
