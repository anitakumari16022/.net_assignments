using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLConnect
{
    internal class Program1
    {
        static void Main(string[] args)
        {          
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=First_Question;Integrated Security=True";

           
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string Sname = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

          
            string query = "INSERT INTO Student (StudentID, Sname, Course, Marks) VALUES (@StudentID, @Sname, @Course, @Marks)";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
       
                SqlCommand command = new SqlCommand(query, connection);

               
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@Sname", Sname);
                command.Parameters.AddWithValue("@Course", course);
                command.Parameters.AddWithValue("@Marks", marks);

                try
                {
                    connection.Open();

                    
                    int rowsAffected = command.ExecuteNonQuery();

                  
                    if (rowsAffected > 0)
                        Console.WriteLine("Record inserted successfully!");
                    else
                        Console.WriteLine("Insert failed. No rows affected.");
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
