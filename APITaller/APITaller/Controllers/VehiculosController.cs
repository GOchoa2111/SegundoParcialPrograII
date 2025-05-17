using APITaller.Models;
using Microsoft.AspNetCore.Mvc;

namespace APITaller.Controllers
{
    [Route("api/vehiculos")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            var vehiculos = new List<Vehiculo>
            {
                new Vehiculo { Id = 1, Placa = "ABC123", Marca = "Toyota", Modelo = "Corolla", Año = 2015, Propietario = "Juan Pérez" },
                new Vehiculo { Id = 2, Placa = "XYZ789", Marca = "Honda", Modelo = "Civic", Año = 2018, Propietario = "María López" },
                new Vehiculo { Id = 3, Placa = "LMN456", Marca = "Ford", Modelo = "Focus", Año = 2017, Propietario = "Carlos Ramírez" }
            };

            return Ok(vehiculos);
        }
    }
}

