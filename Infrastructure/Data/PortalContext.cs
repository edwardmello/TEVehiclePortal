using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options) : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}
