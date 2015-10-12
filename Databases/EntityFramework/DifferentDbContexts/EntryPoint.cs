namespace DifferentDbContexts
{
    using EntityFrameworkNorthwind;
    using System;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            NorthwindEntities dbOne = new NorthwindEntities();
            NorthwindEntities dbTwo = new NorthwindEntities();

            dbOne.Database.Connection.Open();

            Employee employee = new Employee()
            {
                LastName = "Minkov",
                FirstName = "Doncho",
                Title = "Dev Manager",
                TitleOfCourtesy = "Mr",
                BirthDate = new DateTime(1990, 08, 08),
                HireDate = new DateTime(2009, 05, 05),
                Address = "str.Alexander Malinov 31",
                City = "Sofia",
                PostalCode = "1001",
                Country = "Bulgaria"
            };

            dbOne.Employees.Add(employee);
            dbOne.SaveChanges();

            dbTwo.Database.Connection.Open();

            Employee employeeToUpdate = dbTwo.Employees
                .Where(e => e.City.Equals("Sofia"))
                .FirstOrDefault();

            employeeToUpdate.City = "London";
            employeeToUpdate.Address = "Downing Street 10";
            dbTwo.SaveChanges();

            dbOne.Database.Connection.Close();
            dbTwo.Database.Connection.Close();
        }
    }
}
