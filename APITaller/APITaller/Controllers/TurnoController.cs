using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/turnos")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTurnos()
        {
            var turnos = new List<Turno>
            {
                new Turno { Id = 1, ClienteId = 1, VehiculoId = 1, FechaHora = new DateTime(2025, 5, 20, 9, 0, 0), Motivo = "Cambio de aceite" },
                new Turno { Id = 2, ClienteId = 2, VehiculoId = 2, FechaHora = new DateTime(2025, 5, 21, 10, 30, 0), Motivo = "Revisión de frenos" },
                new Turno { Id = 3, ClienteId = 3, VehiculoId = 3, FechaHora = new DateTime(2025, 5, 22, 14, 0, 0), Motivo = "Diagnóstico general" }
            };

            return Ok(turnos);
        }
    }
}

