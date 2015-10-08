namespace AddProduct
{
    using System;
    using System.Data.SqlClient;
    using System.Configuration;

    public class AddProduct
    {
        public static void Main()
        {
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"];
            SqlConnection connection = new SqlConnection(dbConnectionString.ConnectionString);
            int id = Add(connection, "coffee", 1, 1, "10 boxes x 250g", 25.00m, 40, 0, 10, 0);
            Console.WriteLine(string.Format("Product with id {0} added!", id));
        }

        private static int Add(SqlConnection dbCon, string name, int suplierID, int categoryID, 
            string quantity, decimal price, int unitsInStock, int unitsOnOrder, int reorderLevel, int discontinued)
        {
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Products 
                VALUES(@name, @suplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)");

                SqlParameter sqlParameterName = new SqlParameter("@name", name);
                SqlParameter sqlParameterSuplierID = new SqlParameter("@suplierID", suplierID);
                SqlParameter sqlParameterCategoryID = new SqlParameter("@categoryID", categoryID);
                SqlParameter sqlParameterQuantity = new SqlParameter("@quantityPerUnit", quantity);
                SqlParameter sqlParameterPrice = new SqlParameter("@unitPrice", price);
                SqlParameter sqlParameterUnitsInStock = new SqlParameter("@unitsInStock", unitsInStock);
                SqlParameter sqlParameterUnitsOnOrder = new SqlParameter("@unitsOnOrder", unitsOnOrder);
                SqlParameter sqlParameterReorderLevel = new SqlParameter("@reorderLevel", reorderLevel);
                SqlParameter sqlParameterDiscontinued = new SqlParameter("@discontinued", discontinued);
                
                if (name == null)
                {
                    sqlParameterName.Value = DBNull.Value;
                }

                if (quantity == null)
                {
                    sqlParameterQuantity.Value = DBNull.Value;
                }

                command.Parameters.Add(sqlParameterName);
                command.Parameters.Add(sqlParameterSuplierID);
                command.Parameters.Add(sqlParameterCategoryID);
                command.Parameters.Add(sqlParameterQuantity);
                command.Parameters.Add(sqlParameterPrice);
                command.Parameters.Add(sqlParameterUnitsInStock);
                command.Parameters.Add(sqlParameterUnitsOnOrder);
                command.Parameters.Add(sqlParameterReorderLevel);
                command.Parameters.Add(sqlParameterDiscontinued);

                command.Connection = dbCon;
                command.ExecuteNonQuery();
                SqlCommand addedProductID = new SqlCommand("SELECT @@Identity", dbCon);

                int productId = (int)(decimal)addedProductID.ExecuteScalar();
                return productId;
            }
        }
    }
}
