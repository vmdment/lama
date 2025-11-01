using Microsoft.Data.SqlClient;
using System.Data;
namespace Lama.Config
{
    public class ConnectionDB : Interfaces.IConnection
    {
        public string ConnectionString { get; set; }
        public ConnectionDB(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public SqlDataReader? Find(string query) {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = query;
                return command.ExecuteReader();
            }   

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

                     
        }
        public int Execute(string query) {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = query;
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            
        }
    }
}
