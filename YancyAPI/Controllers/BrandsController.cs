using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YancyAPI.Controllers.Resources;
using YancyAPI.Models;
using YancyAPI.Persistence;

namespace YancyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        public IMapper Mapper { get; }
        private readonly YancyDbContext _context;
        public BrandsController(YancyDbContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }
        // GET api/brands
        [HttpGet]
        public async  Task<IEnumerable<BrandResource>> GetBrands()
        {
            var brands = await _context.Brands.
                Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<Brand>, List<BrandResource>>(brands);
        }
    }
}