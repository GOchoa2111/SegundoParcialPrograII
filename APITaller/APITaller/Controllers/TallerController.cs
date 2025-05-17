using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/taller")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTaller()
        {
            var talleres = new List<Taller>
            {
                new Taller
                {
                    Id = 1,
                    Nombre = "Taller El Milagro",
                    Direccion = "5a Avenida 3-45 Zona 1, San Marcos",
                    Telefono = "7760-1234",
                    Correo = "contacto@tallerelmilagro.com"
                }
            };

            return Ok(talleres);
        }
    }
}

