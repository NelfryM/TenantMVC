namespace TenantMVC.Models
{
    public class ElectricityConsumption
    {
        public int Id { get; set; }
        public int IdApartment { get; set; }
        public DateTime Fecha { get; set; }
        public double CantidadKw { get; set; }
    }
}
