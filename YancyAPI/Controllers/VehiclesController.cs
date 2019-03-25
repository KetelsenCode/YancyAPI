using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YancyAPI.Controllers.Resources;
using YancyAPI.Models;
using YancyAPI.Persistence;

namespace YancyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        public IMapper Mapper { get; set; }
        private readonly YancyDbContext _context;
        public VehiclesController(IMapper mapper, YancyDbContext context)
        {
            _context = context;
            Mapper = mapper;
        }
        [HttpGet]
        public string CreateVehicle()
        {
            return "Tesst1";
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var vehicle = Mapper.Map<VehicleResource, Vehicle>(vehicleResource); //From resource to domain model
            vehicle.LastUpdate = DateTime.Now;

            _context.Vehicles.Add(vehicle); //Saves the vehicle in db
            await _context.SaveChangesAsync();

            var result = Mapper.Map<Vehicle, VehicleResource>(vehicle); //Maps it back again to resource
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleResource vehicleResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var vehicle = await _context.Vehicles.FindAsync(id); //Gets the old vehicle with the id
            Mapper.Map<VehicleResource, Vehicle>(vehicleResource, vehicle); //Updates the old vehicle with the new vehicleResource information
            vehicle.LastUpdate = DateTime.Now;

            await _context.SaveChangesAsync();

            var result = Mapper.Map<Vehicle, VehicleResource>(vehicle); //Maps it back again to resource
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            _context.Remove(vehicle);
            await _context.SaveChangesAsync();

            return Ok(id);
        }
    }
}