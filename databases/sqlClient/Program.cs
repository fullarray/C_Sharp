using System;
using System.Data;
using System.Data.SqlClient;

namespace sqlClient
{
    class Program
    {
        static void Main(string[] args)
        {
			string connectionString = "Data Source=(local); Initial Catalog=Northwind; Integrated Security=true";
			string queryString = "SELECT ProductID, UnitPrice, ProductName from dbo.products WHERE UnitPrice > @pricePoint ORDER by UnitPrice DESC;";
			int paramValue = 5;
			
			using(SqlConnection connection = new SqlConnection(ConnectionString))
			{
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.AddWithValue("@pricePoint". paramValue);
				
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while(reader.Read())
					{
						Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
					}
					reader.Close();
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				Console.ReadLine()
			}
        }
    }
}
