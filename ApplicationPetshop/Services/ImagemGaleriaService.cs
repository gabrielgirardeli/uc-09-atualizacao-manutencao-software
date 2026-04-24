using InfrastructurePetshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPetshop.Services
{
    public class ImagemGaleriaService
    {
        private readonly ImagemGaleriaRepository _repository;

        public ImagemGaleriaService(ImagemGaleriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ImagemGaleria>> Listar()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ImagemGaleria> BuscarPorId(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task Criar(ImagemGaleria imagem)
        {
            await _repository.AddAsync(imagem);
        }

        public async Task Atualizar(ImagemGaleria imagem)
        {
            await _repository.UpdateAsync(imagem);
        }

        public async Task Deletar(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
