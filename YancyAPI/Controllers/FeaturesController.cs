using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YancyAPI.Persistence;

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

    }
}