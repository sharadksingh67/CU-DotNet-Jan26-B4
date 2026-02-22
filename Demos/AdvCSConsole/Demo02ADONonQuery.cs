using Microsoft.Data.SqlClient;
using System.Data;

namespace AdvCSConsole
{
    internal class Demo02ADONonQuery
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying ADO.NET");

            try
            {
                using (SqlConnection connection =
                                    new SqlConnection())
                {
                    connection.ConnectionString =
                        "Data Source=.\\sqlexpress;Initial Catalog=Northwind;" +
                        "Integrated Security=True;Trust Server Certificate=True";

                    Console.WriteLine("Connecting SQL Server...");
                    connection.Open();
                    Console.WriteLine(connection.State);
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand();

                        Console.WriteLine("Enter New Category Name - ");
                        string newCat = Console.ReadLine();

                        command.CommandText =
                            $"update categories set categoryname = @newCat where Categoryid=9";

                        command.Parameters.AddWithValue("@newCat", newCat);

                        command.Connection = connection;

                        int effectedRows = command.ExecuteNonQuery();

                        Console.WriteLine($"{effectedRows} rows updated");
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
