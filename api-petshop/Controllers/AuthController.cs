using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiPetshop.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // 🔥 SIMPLES (hardcoded - só pra estudo)
           

            return Unauthorized(new { mensagem = "Credenciais inválidas" });
        }
    }
}
