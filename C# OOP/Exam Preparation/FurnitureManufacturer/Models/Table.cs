
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    public class Table : Furniture, ITable
    {
        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }


        public decimal Length { get; private set; }
        public decimal Width { get; private set; }
        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            string model = this.Model;
            string material = this.Material.ToString();
            decimal price = this.Price;
            decimal height = this.Height;
            decimal length = this.Length;
            decimal width = this.Width;
            decimal area = this.Area;
            string tableToString = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                type, model, material, price, height, length, width, area);

            return tableToString;
        }
    }
}
