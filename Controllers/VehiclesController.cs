using Car_Dealer_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Car_Dealer_Website.Resources;
using AutoMapper;

namespace Car_Dealer_Website.Controllers 
{
    [Route("api/vehicles")]
    public class VehiclesControler: Controller
    {
        private readonly IMapper mapper;

        public VehiclesControler(IMapper mapper) 
        {
            this.mapper = mapper;
        }
        [HttpPost]
        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource) 
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);
        }
    }
}