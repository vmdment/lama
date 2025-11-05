using Lama.Models;
using Microsoft.Data.SqlClient;
using System.Data;
namespace Lama.Config
{
    public class ConnectionDB : Interfaces.IConnection
    {
        private string ConnectionString { get; set; }
        public static readonly ConnectionDB connectionDB = new ConnectionDB("Server=tcp:lama.database.windows.net,1433;Initial Catalog=lama;Persist Security Info=False;User ID=lama;Password=PDN2025-2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private ConnectionDB(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public IEnumerable<Member> Find(string query) {
            try
            {
                LinkedList<Member> list = new LinkedList<Member>();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = query;
                    SqlDataReader sqlData = command.ExecuteReader();
                    while(sqlData.Read())
                    {
                        list.AddLast(new Member(
                 sqlData.GetInt32(0),
                 sqlData.GetString(1),
                 sqlData.GetString(2),
                 sqlData.GetString(3),
                 sqlData.GetString(4),
                 sqlData.GetDateTime(5),
                 sqlData.GetString(6),
                 sqlData.GetInt32(7),
                 sqlData.GetString(8),
                 sqlData.GetString(9),
                 sqlData.GetString(10),
                 sqlData.GetDateTime(11),
                 sqlData.GetString(12),
                 sqlData.GetString(13),
                 sqlData.GetString(14),
                 sqlData.GetString(15),
                 sqlData.GetString(16),
                 sqlData.GetString(17),
                 sqlData.GetString(18),
                 sqlData.GetString(19),
                 sqlData.GetInt32(20),
                 sqlData.GetString(21),
                 sqlData.GetInt32(22),
                 sqlData.GetString(23),
                 sqlData.GetDateTime(24),
                 sqlData.GetDateTime(25)
             ));
                    }
                    sqlData.Close();
                }   
                return list;

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Find {ex.Message}");
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
                Console.WriteLine($"Error Execute {ex.Message}");
                return -1;
            }
            
        }
    }
}
