namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CompanyFactory : ICompanyFactory
    {
        public CompanyFactory()
        {
            this.Companies = new List<Company>();
        }

        public List<Company> Companies { get; private set; } 
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            if(!this.Companies.Any(c => c.Name == name))
            {
                ICompany company = new Company(name, registrationNumber);
                return company;
            }
            return null;
        }
    }
}
