using System.Data;
using Microsoft.Data.SqlClient;

namespace ADODOTNETCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-NSP89M6A\\sqlexpress;" +
                                          "Initial Catalog=EmployeeDB;Integrated Security=True;Encrypt=True;" +
                                          "Trust Server Certificate=True";

                // Calling GetAllEmployees
                GetAllEmployees(connectionString);

                // Calling GetEmployeeByID
                int EmployeeId = 1;
                GetEmployeeByID(connectionString, EmployeeId);

                // Calling CreateEmployeeWithAddress
                string firstName = "Ramesh";
                string lastName = "Sharma";
                string email = "Ramesh@example.com";
                string street = "123 Patia";
                string city = "BBSR";
                string state = "India";
                string postalCode = "755019";

                CreateEmployeeWithAddress(connectionString,
                    firstName, lastName, email, street, city, state, postalCode);

                // Calling UpdateEmployeeWithAddress
                int employeeID = 3;
                firstName = "Rakesh";
                lastName = "Sharma";
                email = "Rakesh@example.com";
                street = "3456 Patia";
                city = "CTC";
                state = "India";
                postalCode = "755024";
                int addressID = 3;

                UpdateEmployeeWithAddress(connectionString, employeeID,
                    firstName, lastName, email, street, city, state, postalCode, addressID);

                // Calling DeleteEmployee
                employeeID = 3;
                DeleteEmployee(connectionString, employeeID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }

        static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeID: {reader["EmployeeID"]}, " +
                                      $"FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}, " +
                                      $"Email: {reader["Email"]}");

                    Console.WriteLine($"Address: {reader["Street"]}, {reader["City"]}, " +
                                      $"{reader["State"]}, PostalCode: {reader["PostalCode"]}\n");
                }

                reader.Close();
                connection.Close();
            }
        }

        static void GetEmployeeByID(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID Stored Procedure Called");

                SqlCommand command = new SqlCommand("GetEmployeeByID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmployeeID", employeeID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Employee: {reader["FirstName"]} {reader["LastName"]}, " +
                                      $"Email: {reader["Email"]}");

                    Console.WriteLine($"Address: {reader["Street"]}, {reader["City"]}, " +
                                      $"{reader["State"]}, {reader["PostalCode"]}");
                }

                reader.Close();
                connection.Close();
            }
        }

        static void CreateEmployeeWithAddress(string connectionString,
            string firstName, string lastName, string email,
            string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("CreateEmployeeWithAddress Stored Procedure Called");

                SqlCommand command = new SqlCommand("CreateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Employee and Address created successfully.");

                connection.Close();
            }
        }

        static void UpdateEmployeeWithAddress(string connectionString, int employeeID,
            string firstName, string lastName, string email,
            string street, string city, string state, string postalCode, int addressID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress Stored Procedure Called");

                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@AddressID", addressID);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Employee and Addresses updated successfully.");

                connection.Close();
            }
        }

        static void DeleteEmployee(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("DeleteEmployee Stored Procedure Called");

                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmployeeID", employeeID);

                connection.Open();

                int result = command.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("Employee and their Address deleted successfully.");
                else
                    Console.WriteLine("Employee not found.");

                connection.Close();
            }
        }
    }
}