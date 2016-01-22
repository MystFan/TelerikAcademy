namespace DataNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class DataSource
    {
        public static List<Employee> GetEmployees()
        {
            SqlConnection dbCon = new SqlConnection(DataNorthwind.Properties.Settings.Default.DbConnection);
            dbCon.Open();

            SqlCommand cmdSelectProject = new SqlCommand(
             "SELECT * FROM Employees", dbCon);
            SqlDataReader reader = cmdSelectProject.ExecuteReader();
            List<Employee> employees = new List<Employee>();

            using (reader)
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = (int)reader["EmployeeID"];
                    employee.FirstName = (string)reader["FirstName"];
                    employee.LastName = (string)reader["LastName"];
                    employee.Job = (string)reader["Title"];
                    employee.BirthDate = (DateTime)reader["BirthDate"];
                    employee.HireDate = (DateTime)reader["HireDate"];
                    employee.Address = (string)reader["Address"];
                    employee.City = (string)reader["City"];
                    employee.Country = (string)reader["Country"];

                    if (reader["HomePhone"] != DBNull.Value)
                    {
                        employee.Phone = (string)reader["HomePhone"];
                    }
                    else
                    {
                        employee.Phone = "-";
                    }

                    employees.Add(employee);
                }
            }

            dbCon.Close();
            return employees;
        }

        public static List<Employee> GetEmployeeById(int id)
        {
            SqlConnection dbCon = new SqlConnection(DataNorthwind.Properties.Settings.Default.DbConnection);
            dbCon.Open();

            SqlCommand cmdSelectProject = new SqlCommand(
             "SELECT * FROM Employees where EmployeeID = @id", dbCon);
            cmdSelectProject.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader reader = cmdSelectProject.ExecuteReader();
            List<Employee> employees = new List<Employee>();

            using (reader)
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = (int)reader["EmployeeID"];
                    employee.FirstName = (string)reader["FirstName"];
                    employee.LastName = (string)reader["LastName"];
                    employee.Job = (string)reader["Title"];
                    employee.BirthDate = (DateTime)reader["BirthDate"];
                    employee.HireDate = (DateTime)reader["HireDate"];
                    employee.Address = (string)reader["Address"];
                    employee.City = (string)reader["City"];
                    employee.Country = (string)reader["Country"];

                    if (reader["HomePhone"] != DBNull.Value)
                    {
                        employee.Phone = (string)reader["HomePhone"];
                    }
                    else
                    {
                        employee.Phone = "-";
                    }

                    employees.Add(employee);
                }
            }

            dbCon.Close();
            return employees;
        }

        public static List<Employee> GetSortedByQueryEmployees(string query)
        {
            SqlConnection dbCon = new SqlConnection(DataNorthwind.Properties.Settings.Default.DbConnection);
            dbCon.Open();

            SqlCommand cmdSelectProject = new SqlCommand(query, dbCon);
            SqlDataReader reader = cmdSelectProject.ExecuteReader();
            List<Employee> employees = new List<Employee>();

            using (reader)
            {
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = (int)reader["EmployeeID"];
                    employee.FirstName = (string)reader["FirstName"];
                    employee.LastName = (string)reader["LastName"];
                    employee.Job = (string)reader["Title"];
                    employee.BirthDate = (DateTime)reader["BirthDate"];
                    employee.HireDate = (DateTime)reader["HireDate"];
                    employee.Address = (string)reader["Address"];
                    employee.City = (string)reader["City"];
                    employee.Country = (string)reader["Country"];

                    if (reader["HomePhone"] != DBNull.Value)
                    {
                        employee.Phone = (string)reader["HomePhone"];
                    }
                    else
                    {
                        employee.Phone = "-";
                    }

                    employees.Add(employee);
                }
            }

            dbCon.Close();
            return employees;
        }
    }
}