using Lama.Domain;
using Lama.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Lama.Services
{
    public class MemberService
    {
        private readonly IConnection _connection;
        public MemberService(IConnection connection) { 
            _connection = connection;
        }
        public Member AddMember(Member member)
        {
            
        }
        public int DeleteMember(int id) {
            return 1;
        }
        public int UpdateMemberEmail(string name, string newEmail) {
            return 1;
        }
        public string GetOneById(int id) {
            return "Member";
        }
        public async Task<List<string>> GetAllMembers() {
            return new List<string>() { "Member1", "Member2" };            
        }
        
    }
}
