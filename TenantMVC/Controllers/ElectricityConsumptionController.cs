using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenantMVC.Models;

namespace TenantMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityConsumptionController : ControllerBase
    {
        // Lista temporal para simular una base de datos.
        private static List<ElectricityConsumption> consumptions = new List<ElectricityConsumption>();

        [HttpGet]
        public IActionResult GetConsumptions() => Ok(consumptions);

        [HttpGet("{id}")]
        public IActionResult GetConsumption(int id)
        {
            var consumption = consumptions.FirstOrDefault(c => c.Id == id);
            return consumption != null ? Ok(consumption) : NotFound();
        }

        [HttpPost]
        public IActionResult CreateConsumption([FromBody] ElectricityConsumption consumption)
        {
            if (ModelState.IsValid)
            {
                consumptions.Add(consumption);
                return CreatedAtAction(nameof(GetConsumption), new { id = consumption.Id }, consumption);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateConsumption(int id, [FromBody] ElectricityConsumption consumption)
        {
            var existingConsumption = consumptions.FirstOrDefault(c => c.Id == id);
            if (existingConsumption == null) return NotFound();

            existingConsumption.IdApartment = consumption.IdApartment;
            existingConsumption.Fecha = consumption.Fecha;
            existingConsumption.CantidadKw = consumption.CantidadKw;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConsumption(int id)
        {
            var consumption = consumptions.FirstOrDefault(c => c.Id == id);
            if (consumption == null) return NotFound();

            consumptions.Remove(consumption);
            return NoContent();
        }
    }

}
