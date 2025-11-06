using Lama.Config;
using Lama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Necesario para métodos como ToArrayAsync
// using Lama.Services;  // Ya no necesario si se usa DbContext directamente

namespace Lama.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        //  Ahora _context es el DbContext
        private readonly ApplicationDbContext _context;

        //  Se inyecta _context directamente
        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MemberModel>> GetMembers()
        {
            // Uso de _context para acceder a los datos
            return await _context.Miembros.ToArrayAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberModel>> GetMember(int id)
        {
            var member = await _context.Miembros.FindAsync(id);
            if (member == null) return NotFound();
            return member;
        }

        [HttpPost]
        public async Task<ActionResult<MemberModel>> CreateMember(MemberModel member)
        {
            _context.Miembros.Add(member);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMember), new { id = member.Id }, member);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMember(int id, MemberModel member)
        {
            //if (id != member.Id) return BadRequest();
            member.Id = id;
            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMemberById(int id)
        {
            var member = await _context.Miembros.FindAsync(id);
            if (member == null) return NotFound();
            _context.Miembros.Remove(member);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
