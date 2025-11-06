using Microsoft.EntityFrameworkCore;
using Lama.Models;
namespace Lama.Config
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        // Tus DbSets (tablas)
        public DbSet<MemberModel> Miembros { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones de modelo si las necesitas
        }
    }
}
