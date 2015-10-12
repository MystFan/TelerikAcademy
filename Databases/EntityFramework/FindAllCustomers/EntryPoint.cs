namespace FindAllCustomers
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        public static void Main()
        {
            var db = new NorthwindEntities();

            using (db)
            {
                var customers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                    .Select(o => o.Customer)
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
        }
    }
}
