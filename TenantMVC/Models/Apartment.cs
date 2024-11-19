using System.ComponentModel.DataAnnotations;

namespace TenantMVC.Models
{
    public class Apartment
    {
        public int IdApartment { get; set; }


        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        
        [Required]
        [Phone]
        public string Telefono { get; set; }
    }
}
