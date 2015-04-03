namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public FurnitureFactory()
        {
            this.Tables = new List<ITable>();
            this.Chairs = new List<IChair>();
        }

        public List<ITable> Tables { get; private set; }
        public List<IChair> Chairs { get; private set; }
        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            if (!this.Tables.Any(t => t.Model == model))
            {
                ITable table = new Table(model, GetMaterialType(materialType).ToString(), price, height, length, width);
                this.Tables.Add(table);
                return table;
            }
            return null;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!this.Chairs.Any(c => c.Model == model))
            {
                IChair chair = new Chair(model, GetMaterialType(materialType).ToString(), price, height, numberOfLegs);
                this.Chairs.Add(chair);
                return chair;
            }
            return null;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!this.Chairs.Any(c => c.Model == model))
            {
                IAdjustableChair chair = new AdjustableChair(model, GetMaterialType(materialType).ToString(), price, height, numberOfLegs);
                this.Chairs.Add(chair);
                return chair;
            }
            return null;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!this.Chairs.Any(c => c.Model == model))
            {
                IConvertibleChair chair = new ConvertibleChair(model, GetMaterialType(materialType).ToString(), price, height, numberOfLegs);
                this.Chairs.Add(chair);
                return chair;
            }
            return null;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
