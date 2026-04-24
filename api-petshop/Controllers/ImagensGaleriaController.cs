using ApplicationPetshop.Services;
using Microsoft.AspNetCore.Mvc;
using DomainPetshop.Entities.Domain;


namespace ApiPetshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImagensGaleriaController : ControllerBase
    {
        private readonly ImagemGaleriaService _service;

        public ImagensGaleriaController(ImagemGaleriaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var imagens = await _service.Listar();
            return Ok(imagens);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var imagem = await _service.BuscarPorId(id);

            if (imagem == null)
                return NotFound();

            return Ok(imagem);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ImagemGaleria imagem)
        {
            await _service.Criar(imagem);
            return Created("", imagem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ImagemGaleria imagem)
        {
            if (id != imagem.Id)
                return BadRequest();

            await _service.Atualizar(imagem);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Deletar(id);
            return NoContent();
        }
    }
}
