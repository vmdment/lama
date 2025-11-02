using Lama.Config;
using Lama.Models;
using Lama.Repositories;
using Lama.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lama.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MiembrosController : ControllerBase
    {
        private readonly MemberService _memberService;

        public MiembrosController()
        {
           _memberService = new MemberService(new MemberRepository(ConnectionDB.connectionDB));

        }
        [HttpGet]
        public async Task<IEnumerable<Member>> GetMembers()
        {
            return _memberService.GetAllMembers();
        }
        [HttpGet("{id}")]
        public  Member GetMiembro(int id)
        {
            try
            {
                return _memberService.GetOneById(id);
            }
            catch (Exception)
            {
                throw;
              
            }
        }
        [HttpPost]
        public async Task<Member> PostMiembro(Member miembro)
        {
            try
            {
               return _memberService.AddMember(miembro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMiembro(int id, Member miembro)
        //{
        //    return _memberService.UpdateMemberEmail(miembro.Nombre,);
        //}
        [HttpDelete("{id}")]
        public async Task<Member> DeleteMiembro(int id)
        {
            try
            {
                return _memberService.DeleteMember(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
