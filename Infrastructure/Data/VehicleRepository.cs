using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        public PortalContext _context; 

        public VehicleRepository(PortalContext context)
        {
            _context = context;
        }

        public async  Task<IReadOnlyList<Branch>> GetAllVehicleBranchesAsync()
        {
            return await _context.Branches.ToListAsync();
        }

        public async Task<IReadOnlyList<Vehicle>> GetAllVehiclesAsync()
        {
            return await _context.Vehicles
                .Include(v => v.VehicleType)
                .Include(v => v.Branch)
                .Include(v => v.Status)
                .ToListAsync(); 
        }

        public async Task<IReadOnlyList<Status>> GetAllVehicleStatusesAsync()
        {
            return await _context.Statuses.ToListAsync();
        }

        public async Task<IReadOnlyList<VehicleType>> GetAllVehicleTypesAsync()
        {
            return await _context.VehicleTypes.ToListAsync();
        }

        public async Task<Vehicle> GetVehiclebyIdAsync(int id)
        {
            return await _context.Vehicles
                .Include(v => v.VehicleType)
                .Include(v => v.Branch)
                .Include(v => v.Status)
                .FirstOrDefaultAsync(v => v.Id == id);
        }
    }
}
