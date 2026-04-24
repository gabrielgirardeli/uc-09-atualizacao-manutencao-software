using DomainPetshop.Entities.Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ContatoRepository
    {
        private readonly AppDbContext _context;

        public ContatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Contato contato)
        {
            await _context.Contatos.AddAsync(contato);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Contato>> GetAllAsync()
        {
            return await _context.Contatos.ToListAsync();
        }

        public async Task DeletarContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);

            if (contato == null)
                return;

            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
        }
    }
}