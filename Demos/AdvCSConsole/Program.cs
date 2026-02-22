//using Microsoft.Data.SqlClient;
//using System.Data;

//namespace AdvCSConsole
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(  "Trying ADO.NET");

//            try
//            {
//                using (SqlConnection connection =
//                                    new SqlConnection())
//                {
//                    connection.ConnectionString =
//                        "Data Source=.\\sqlexpress;Initial Catalog=Northwind;" +
//                        "Integrated Security=True;Trust Server Certificate=True";

//                    Console.WriteLine("Connecting SQL Server...");
//                    connection.Open();
//                    Console.WriteLine(connection.State);
//                    if (connection.State == ConnectionState.Open)
//                    {
//                        SqlCommand command = new SqlCommand();
//                        command.CommandText =
//                            "select CategoryId, CategoryName from Categories" +
//                            " order by CategoryId";
//                        command.Connection = connection;

//                        //SqlDataReader reader = command.ExecuteReader();

//                        ////reader.Read();
//                        ////Console.WriteLine($"{reader[0]}, {reader[1]}");

//                        //while (reader.Read())
//                        //{
//                        //    Console.WriteLine($"{reader[0]}, {reader[1]}");
//                        //}

//                        //Console.WriteLine("Completed Data Reading...");
//                    }
                    
//                }
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex);
//            }
//        }
//    }
//}
