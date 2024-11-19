using Microsoft.EntityFrameworkCore;
using TenantMVC.Models;


namespace TenantMVC.Data
{
    public class TenantDbContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ElectricityConsumption> ElectricityConsumptions { get; set; }

        public TenantDbContext(DbContextOptions<TenantDbContext> options) : base(options) { }
    }

}