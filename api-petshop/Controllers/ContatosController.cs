using Application.Services;
using DomainPetshop.Entities.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiPetshop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatosController : ControllerBase
    {
        private readonly ContatoService _service;

        public ContatosController(ContatoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Contato contato)
        {
            await _service.CriarContato(contato);
            return Ok(new { mensagem = "Contato salvo com sucesso!" });
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contatos = await _service.ListarContatos();
            return Ok(contatos);
        }
    }




}
