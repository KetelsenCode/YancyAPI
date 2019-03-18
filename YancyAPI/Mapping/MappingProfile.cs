using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YancyAPI.Controllers.Resources;
using YancyAPI.Models;

namespace YancyAPI.Mapping
{
    public class MappingProfile : Profile
    {
        //Maps Brand and Model to BrandResource & ModelResource 
        public MappingProfile()
        {
            CreateMap<Brand, BrandResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}
