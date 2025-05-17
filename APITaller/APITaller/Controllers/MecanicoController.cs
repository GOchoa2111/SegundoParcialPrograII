using APITaller.Models;
using Microsoft.AspNetCore.Mvc;

namespace APITaller.Controllers
{
    [Route("api/mecanicos")]
    [ApiController]
    public class MecanicosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMecanicos()
        {
            var mecanicos = new List<Mecanico>
            {
                new Mecanico { Id = 1, Nombre = "Luis Herrera", Especialidad = "Transmisiones", AñosExperiencia = 10 },
                new Mecanico { Id = 2, Nombre = "Ana Morales", Especialidad = "Frenos y suspensión", AñosExperiencia = 7 },
                new Mecanico { Id = 3, Nombre = "Carlos Díaz", Especialidad = "Diagnóstico electrónico", AñosExperiencia = 12 }
            };

            return Ok(mecanicos);
        }
    }
}

