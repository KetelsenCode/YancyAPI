using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YancyAPI.Models;

namespace YancyAPI.Persistence
{
    public class YancyDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public YancyDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
