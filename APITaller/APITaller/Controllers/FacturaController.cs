using APITaller.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APITaller.Controllers
{
    [Route("api/facturas")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFacturas()
        {
            var facturas = new List<Factura>
            {
                new Factura
                {
                    Id = 1,
                    ClienteId = 1,
                    FechaEmision = new DateTime(2025, 5, 15),
                    Detalles = new List<string>
                    {
                        "Cambio de aceite - Q250.00",
                        "Filtro de aceite - Q45.00"
                    },
                    Total = 295.00m
                },
                new Factura
                {
                    Id = 2,
                    ClienteId = 2,
                    FechaEmision = new DateTime(2025, 5, 16),
                    Detalles = new List<string>
                    {
                        "Revisión de frenos - Q200.00",
                        "Pastillas de freno - Q120.00"
                    },
                    Total = 320.00m
                },
                new Factura
                {
                    Id = 3,
                    ClienteId = 3,
                    FechaEmision = new DateTime(2025, 5, 17),
                    Detalles = new List<string>
                    {
                        "Diagnóstico general - Q150.00"
                    },
                    Total = 150.00m
                }
            };

            return Ok(facturas);
        }
    }
}
