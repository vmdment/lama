using Microsoft.Data.SqlClient;
using System.Data;
namespace Lama.Config
{
    public class ConnectionDB : Interfaces.IConnection
    {
        private string ConnectionString { get; set; }
        public static readonly ConnectionDB connectionDB = new ConnectionDB("Server=tcp:lama.database.windows.net,1433;Initial Catalog=lama;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\"");
        private ConnectionDB(string connectionString)
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
