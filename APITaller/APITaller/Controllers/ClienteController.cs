using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Jorge Castillo", Telefono = "5555-1234", CorreoElectronico = "jorge.castillo@email.com" },
                new Cliente { Id = 2, Nombre = "Laura Méndez", Telefono = "5555-5678", CorreoElectronico = "laura.mendez@email.com" },
                new Cliente { Id = 3, Nombre = "Ricardo Gómez", Telefono = "5555-9012", CorreoElectronico = "ricardo.gomez@email.com" }
            };

            return Ok(clientes);
        }
    }
}

