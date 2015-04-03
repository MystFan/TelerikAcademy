
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FurnitureManufacturer.Interfaces;
    using System.Text;
    public class Company : ICompany
    {
        private const int RegistrationNumberLength = 10;
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;
        public Company(string name, string registarationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registarationNumber;
            this.Furnitures = new List<IFurniture>();
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Company name is null");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Company name must be at least 5 characters");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Company name is empty");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber; 
            }
            private set
            {
                if (value.Length > RegistrationNumberLength || value.Length < RegistrationNumberLength)
                {
                    throw new ArgumentException("Company registration number should be exact 10 digits");
                }
                if (!isValidNumber(value))
                {
                    throw new ArgumentException("Company registration number should contains only digits");
                }
                this.registrationNumber = value;
            }
        }


        public ICollection<IFurniture> Furnitures
        {
            get 
            {
                return this.furnitures;
            }
            private set
            {
                this.furnitures = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
            this.Furnitures = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model).ToList();
        }

        public void Remove(IFurniture furniture)
        {
            if (this.Furnitures.Count > 0)
            {
                IFurniture firstFurniture = this.Furnitures.FirstOrDefault(f => f.Model == furniture.Model);
                this.Furnitures.Remove(firstFurniture);
            }
        }

        public IFurniture Find(string model)
        {
            IFurniture result = null;
            result = this.Furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
            return result;
        }

        public string Catalog()
        {
            StringBuilder sb = new StringBuilder();
            string catalogTitle = string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                );
            sb.AppendLine(catalogTitle);
            foreach (var furniture in this.Furnitures)
            {
                sb.AppendLine(furniture.ToString());
            }
            return sb.ToString().Remove(sb.Length - 2);
        }


        private bool isValidNumber(string regNumber)
        {
            for (int i = 0; i < regNumber.Length; i++)
            {
                if (char.IsLetter(regNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
