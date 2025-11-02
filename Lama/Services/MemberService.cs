using Lama.Interfaces;
using Lama.Models;
using Lama.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Lama.Services
{
    public class MemberService
    {
        private readonly MemberRepository _memberRepository;
        public MemberService(MemberRepository memberRepository) {
            _memberRepository = memberRepository;
        }
        public Member AddMember(Member member)
        {
            return _memberRepository.Create(member);
        }
        public Member DeleteMember(int id) {
            return _memberRepository.DeleteOneBy("Id",id.ToString());
        }
        public Member UpdateMemberEmail(string name, string newEmail) {
            return _memberRepository.Update("Email", newEmail, "Nombre", name);
        }
        public Member GetOneById(int id) {
            return _memberRepository.FindOneBy("Id", id.ToString());
        }
        public IEnumerable<Member> GetAllMembers() {
            return _memberRepository.FindAll();         
        }
        
    }
}
