using System;
using System.Data.SqlClient;

namespace SQLConnectionExample
{
    class Program3
    {
        static void Main(string[] args)
        {
            
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=First_Question;Integrated Security=True";

            string query = "SELECT StudentID, Name, Course, Marks FROM Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
          
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    Console.WriteLine("Connection established successfully!\n");

                 
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("Student Records:");
                    Console.WriteLine("------------------------------------------");

                  
                    while (reader.Read())
                    {
                        Console.WriteLine($"StudentID: {reader["StudentID"]}, Sname: {reader["Sname"]}, Course: {reader["Course"]}, Marks: {reader["Marks"]}");
                    }

                   
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("\nConnection closed.");
                }
            }

            Console.ReadLine();
        }
    }
}
