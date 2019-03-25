using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YancyAPI.Models;
using YancyAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using YancyAPI.Controllers.Resources;

namespace YancyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        public IMapper Mapper { get; }
        private readonly YancyDbContext _context;
        public FeaturesController(YancyDbContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var models = await _context.Features.ToListAsync();
            return Mapper.Map<List<Feature>, List<FeatureResource>>(models);

        }
    }
}