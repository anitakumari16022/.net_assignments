using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnect
{
    internal class Program4
    {
        static void Main(string[] args) {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=First_Question;Integrated Security=True";

           
            Console.Write("Enter Student ID to update: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new Marks: ");
            int newMarks = Convert.ToInt32(Console.ReadLine());

            string query = "UPDATE Student SET Marks = @Marks WHERE StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(query, connection);

               
                command.Parameters.AddWithValue("@Marks", newMarks);
                command.Parameters.AddWithValue("@StudentID", studentId);

                try
                {
                    connection.Open();
                    Console.WriteLine("\nConnection established successfully!");

                    int rowsAffected = command.ExecuteNonQuery();

                   
                    if (rowsAffected > 0)
                        Console.WriteLine($"Update successful! {rowsAffected} row(s) affected.");
                    else
                        Console.WriteLine("No record found with the given Student ID.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }

            Console.ReadLine();
        }
    }
}

