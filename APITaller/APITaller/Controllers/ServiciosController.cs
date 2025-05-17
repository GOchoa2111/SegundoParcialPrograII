using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/servicios")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetServicios()
        {
            var servicios = new List<Servicio>
            {
                new Servicio { Id = 1, NombreServicio = "Cambio de aceite", Descripcion = "Incluye aceite y filtro", Precio = 250.00m },
                new Servicio { Id = 2, NombreServicio = "Alineación y balanceo", Descripcion = "Alineación de ejes y balanceo de llantas", Precio = 300.00m },
                new Servicio { Id = 3, NombreServicio = "Revisión de frenos", Descripcion = "Inspección y ajuste de frenos", Precio = 200.00m }
            };

            return Ok(servicios);
        }
    }
}

