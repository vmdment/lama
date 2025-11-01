using Lama.Domain;
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

        public MiembrosController(MemberService memberService)
        {
           _memberService = memberService;

        }
        [HttpGet]
        public async Task<IEnumerable<Member>> GetMembers()
        {
            return _memberService.GetAllMembers();
        }
        [HttpGet("{id}")]
        public async Task<Member> GetMiembro(int id)
        {
            var miembro = await _context.Miembros.FindAsync(id);
            if (miembro == null) return NotFound();
            return miembro;
        }
        [HttpPost]
        public async Task<Member> PostMiembro(Member miembro)
        {
            _context.Miembros.Add(miembro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMiembro), new { id = miembro.Id }, miembro);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiembro(int id, Member miembro)
        {
            if (id != miembro.Id) return BadRequest();
            _context.Entry(miembro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiembro(int id)
        {
            var miembro = await _context.Miembros.FindAsync(id);
            if (miembro == null) return NotFound();
            _context.Miembros.Remove(miembro);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
