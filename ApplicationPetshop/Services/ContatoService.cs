using DomainPetshop.Entities.Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class ContatoService
    {
        private readonly ContatoRepository _repository;

        public ContatoService(ContatoRepository repository)
        {
            _repository = repository;
        }

        public async Task CriarContato(Contato contato)
        {
            contato.DataEnvio = DateTime.Now;
            await _repository.AddAsync(contato);
        }


        public async Task<List<Contato>> ListarContatos()
        {
            return await _repository.GetAllAsync();
        }
    }
}