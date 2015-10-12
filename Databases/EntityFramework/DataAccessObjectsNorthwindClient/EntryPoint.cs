namespace DataAccessObjectsNorthwindClient
{
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        public static void Main()
        {
            NorthwindDataAccessObject.InsertCustomer(
                "JJJJJ",
                "The Company",
                "Jhon Doe",
                "Batman",
                "Al. Malinov 31",
                "SinCity",
                "Unknown",
                "1000",
                "U.S.A",
                "555-123456",
                "555-654321");

            NorthwindDataAccessObject.UpdateCustomer(
                "JJJJJ",
                "The New Company",
                "Doncho Minkov",
                "Batman",
                "Al. Malinov 31",
                "Sofia",
                "Unknown",
                "1000",
                "Javascript",
                "555-123456",
                "555-654321");

            NorthwindDataAccessObject.DeleteCustomerById("JJJJJ");
        }
    }
}
