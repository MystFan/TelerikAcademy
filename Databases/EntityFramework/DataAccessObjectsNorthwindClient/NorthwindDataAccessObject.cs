namespace DataAccessObjectsNorthwindClient
{
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class NorthwindDataAccessObject
    {
        public static void InsertCustomer(
            string id,
            string commpanyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax)
        {
            var db = new NorthwindEntities();

            using (db)
            {
                Customer customer = new Customer()
                {
                    CustomerID = id,
                    CompanyName = commpanyName,
                    ContactName = contactName,
                    ContactTitle = contactTitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                };

                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void UpdateCustomer(
           string id,
           string commpanyName,
           string contactName,
           string contactTitle,
           string address,
           string city,
           string region,
           string postalCode,
           string country,
           string phone,
           string fax)
        {
            var db = new NorthwindEntities();

            using (db)
            {
                Customer customer = db.Customers.Where(c => c.CustomerID == id).FirstOrDefault();

                customer.CustomerID = id;
                customer.CompanyName = commpanyName;
                customer.ContactName = contactName;
                customer.ContactTitle = contactTitle;
                customer.Address = address;
                customer.City = city;
                customer.Region = region;
                customer.PostalCode = postalCode;
                customer.Country = country;
                customer.Phone = phone;
                customer.Fax = fax;

                db.SaveChanges();
            }
        }

        public static void DeleteCustomerById(string id)
        {
            var db = new NorthwindEntities();

            using (db)
            {
                Customer customer = db.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
                db.Customers.Remove(customer);

                db.SaveChanges();
            }
        }
    }
}
