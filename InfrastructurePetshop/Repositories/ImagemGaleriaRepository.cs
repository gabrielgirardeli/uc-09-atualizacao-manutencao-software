using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace InfrastructurePetshop.Repositories
{
    public class ImagemGaleriaRepository
    {
        private readonly AppDbContext _context;

        public ImagemGaleriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ImagemGaleria>> GetAllAsync()
        {
            return await _context.ImagensGaleria.ToListAsync();
        }

        public async Task<ImagemGaleria> GetByIdAsync(int id)
        {
            return await _context.ImagensGaleria.FindAsync(id);
        }

        public async Task AddAsync(ImagemGaleria imagem)
        {
            _context.ImagensGaleria.Add(imagem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ImagemGaleria imagem)
        {
            _context.ImagensGaleria.Update(imagem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var img = await _context.ImagensGaleria.FindAsync(id);
            if (img == null) return;

            _context.ImagensGaleria.Remove(img);
            await _context.SaveChangesAsync();
        }
    }
}
