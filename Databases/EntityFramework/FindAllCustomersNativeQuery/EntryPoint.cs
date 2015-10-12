namespace FindAllCustomersNativeQuery
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        static void Main()
        {
            SelectCustomers();
        }

        public static void SelectCustomers()
        {
            NorthwindEntities db = new NorthwindEntities();
            string nativeSqlQuery = @"SELECT c.[CustomerID], c.[CompanyName], c.[ContactName], c.[ContactTitle],
                                        c.[Address], c.[City], c.[Region], c.[PostalCode], c.[Country], c.[Phone], c.[Fax]
                                      FROM Northwind.dbo.Orders o
	                                        INNER JOIN Northwind.dbo.Customers c
	                                        ON (o.CustomerID = c.CustomerID)
	                                        WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";

            using (db)
            {
                var queryResult = db.Database.SqlQuery<CustomerFromDatabase>(nativeSqlQuery);
                var customers = queryResult.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
        }
    }
}
