namespace EmploeeExtended
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        public static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();

            using (db)
            {
                db.Employees.Include("Territories");

                var employeesData = db.Employees
                    .Select(e =>
                    new
                    {
                        Employee = e,
                        Territories = e.Territories.Select(t => t.TerritoryDescription)
                    })
                    .ToList();

                foreach (var data in employeesData)
                {
                    Console.WriteLine(data.Employee.FirstName + " " + data.Employee.LastName);
                    Console.WriteLine("Territories:");
                    foreach (var teritory in data.Territories)
                    {
                        Console.WriteLine(teritory);
                    }
                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}
