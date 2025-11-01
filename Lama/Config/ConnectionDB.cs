using System;
using Microsoft.Data.SqlClient;
namespace Lama.Config
{
    public class ConnectionDB
    {
        public string ConnectionString { get; set; }
        public ConnectionDB(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public SqlDataReader Find(string query) {
            
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                return command.ExecuteReader();
            }            
        }
        public int Execute(string query) {
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
        }
    }
}
