using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TEVehiclePortal.Controllers.Gateway
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository _repository;

        public VehiclesController(IVehicleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> GetVehicles()
        {
            var vehicles = await _repository.GetAllVehiclesAsync();
            return Ok(vehicles);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            return await _repository.GetVehiclebyIdAsync(id);
        }

        [HttpGet("vehicleTypes")]
        public async Task<ActionResult<IReadOnlyList<VehicleType>>> GetVehicleTypes()
        {
            return Ok(await _repository.GetAllVehicleTypesAsync());
        }

        [HttpGet("branches")]
        public async Task<ActionResult<IReadOnlyList<Branch>>> GetVehicleBranches()
        {
            return Ok(await _repository.GetAllVehicleBranchesAsync());
        }

        [HttpGet("statuses")]
        public async Task<ActionResult<IReadOnlyList<Status>>> GetVehicleStatuses()
        {
            return Ok(await _repository.GetAllVehicleStatusesAsync());
        }
    }
}
