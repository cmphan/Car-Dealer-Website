using Car_Dealer_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Car_Dealer_Website.Resources;
using AutoMapper;
using Car_Dealer_Website.Persistence;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace Car_Dealer_Website.Controllers 
{
    [Route("api/vehicles")]
    public class VehiclesControler: Controller
    {
        private readonly IMapper mapper;
        private readonly CarDealerDbContext context;

        public VehiclesControler(IMapper mapper, CarDealerDbContext context) 
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource) 
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdated = DateTime.Now;
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleResource vehicleResource) 
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var vehicle = await context.Vehicles.Include(v => v.Features).SingleOrDefaultAsync(v => v.Id == id);
            mapper.Map<VehicleResource, Vehicle>(vehicleResource, vehicle);
            vehicle.LastUpdated = DateTime.Now;
            await context.SaveChangesAsync();
            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(vehicle);
        }
    }
}