using Microsoft.AspNetCore.Mvc;

namespace FutureSkillHub.Api.Controllers
{
    [ApiController]
    [Route("api/v2/cursos")]
    public class CursoV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Ok(new { mensagem = "Versão 2 da API - endpoint simplificado" });
    }
}
