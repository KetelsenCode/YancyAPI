using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YancyAPI.Controllers.Resources
{
    //Resources are like a viewmodel for APIs
    public class FeatureResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
