using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void main()
    {
       
        string connectionString = @"Data Source=DESKTOP-TIC5DM4\SQLEXPRESS;database=Dotnet;integrated security=SSPI";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
              //  Console.WriteLine("Connection opened successfully.");


                string query = "select * from Emp";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("List the table :");

                        while (reader.Read())
                        {
                            Console.WriteLine(reader["customer\nproduct\nStudent"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    //Console.WriteLine("Connection closed.");
                }
            }
        }
    }
}




