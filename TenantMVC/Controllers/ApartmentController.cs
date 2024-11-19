using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenantMVC.Models;

namespace TenantMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        // Lista temporal para simular una base de datos.
        private static List<Apartment> apartments = new List<Apartment>();

        [HttpGet]
        public IActionResult GetApartments() => Ok(apartments);

        [HttpGet("{id}")]
        public IActionResult GetApartment(int id)
        {
            var apartment = apartments.FirstOrDefault(a => a.IdApartment == id);
            return apartment != null ? Ok(apartment) : NotFound();
        }

        [HttpPost]
        public IActionResult CreateApartment([FromBody] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                apartments.Add(apartment);
                return CreatedAtAction(nameof(GetApartment), new { id = apartment.IdApartment }, apartment);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateApartment(int id, [FromBody] Apartment apartment)
        {
            var existingApartment = apartments.FirstOrDefault(a => a.IdApartment == id);
            if (existingApartment == null) return NotFound();

            existingApartment.Nombre = apartment.Nombre;
            existingApartment.Telefono = apartment.Telefono;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteApartment(int id)
        {
            var apartment = apartments.FirstOrDefault(a => a.IdApartment == id);
            if (apartment == null) return NotFound();

            apartments.Remove(apartment);
            return NoContent();
        }
    }

}
