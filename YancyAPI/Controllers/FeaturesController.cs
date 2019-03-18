using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YancyAPI.Models;
using YancyAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace YancyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly YancyDbContext _context;
        public FeaturesController(YancyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Feature>> GetFeatures()
        {
            return await _context.Features.ToListAsync();
        }
    }
}