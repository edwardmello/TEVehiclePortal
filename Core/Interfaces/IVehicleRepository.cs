using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehiclebyIdAsync(int id);
        Task<IReadOnlyList<Vehicle>> GetAllVehiclesAsync();

        Task<IReadOnlyList<VehicleType>> GetAllVehicleTypesAsync();
        Task<IReadOnlyList<Branch>> GetAllVehicleBranchesAsync();
        Task<IReadOnlyList<Status>> GetAllVehicleStatusesAsync();



    }
}
