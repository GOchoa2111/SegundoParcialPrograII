using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/repuestos")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRepuestos()
        {
            var repuestos = new List<Repuesto>
            {
                new Repuesto { Id = 1, Nombre = "Filtro de aceite", Marca = "Bosch", Stock = 25, },
                new Repuesto { Id = 2, Nombre = "Pastillas de freno", Marca = "Brembo", Stock = 15, },
                new Repuesto { Id = 3, Nombre = "Batería 12V", Marca = "LTH", Stock = 10, }
            };

            return Ok(repuestos);
        }
    }
}

