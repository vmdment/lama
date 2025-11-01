using Microsoft.Data.SqlClient;

namespace Lama.Interfaces
{
    public interface IConnection
    {
        int Execute(string query);
        SqlDataReader? Find(string query);
    }
}
