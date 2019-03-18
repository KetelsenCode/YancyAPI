using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using YancyAPI.Models;

namespace YancyAPI.Controllers.Resources
{
    //Resources are like a viewmodel for APIs
    public class BrandResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        public BrandResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}
