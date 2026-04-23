using DomainPetshop.Entities.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}