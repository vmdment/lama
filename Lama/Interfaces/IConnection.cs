using Lama.Models;


namespace Lama.Interfaces
{
    public interface IConnection
    {
        int Execute(string query);
        IEnumerable<Member> Find(string query);
    }
}
