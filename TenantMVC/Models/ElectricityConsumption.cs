using System.ComponentModel.DataAnnotations;

namespace TenantMVC.Models
{
    public class ElectricityConsumption
    {
        public int Id { get; set; }

        [Required]
        public int IdApartment { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public double CantidadKw { get; set; }
    }
}
